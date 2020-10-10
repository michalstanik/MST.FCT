using AutoMapper;
using FCT.Data;
using FCT.Data.IRepositories;
using FCT.Data.Repositories;
using FCT.Data.Seeders;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MST.Flogging.Core.Filters;

namespace MST.FCT.API.FCTApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var requireAuthenticatedUserPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();


            // register an IHttpContextAccessor so we can access the current HttpContext in services by injecting it
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper(typeof(Startup));

            #region Seeders
            services.AddTransient<DictionarySeeder>();
            services.AddTransient<EnsureDB>();
            #endregion Seeders

            #region Repositories
            services.AddScoped<IAviationRepository, AviationRepository>();
            # endregion Repositories

            services.AddDbContext<FCTContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("FCTConnectionString"));
            });

            services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });

            services.AddControllers(setupAction =>
            {
                setupAction.Filters.Add(new TrackPerformanceFilter());
                setupAction.Filters.Add(new AuthorizeFilter(requireAuthenticatedUserPolicy));
            });

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            .AddIdentityServerAuthentication(options =>
            {
                options.Authority = "https://localhost:5001/";
                options.ApiName = "fctapi";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseStatusCodePages();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Seed the database

            //using IServiceScope scope = app.ApplicationServices.CreateScope();
            //var recreate = scope.ServiceProvider.GetService<EnsureDB>();
            //var dictionarySeeder = scope.ServiceProvider.GetService<DictionarySeeder>();

            //recreate.EnsureDeletedAndRecreated();
            //dictionarySeeder.Seed();
        }
    }
}
