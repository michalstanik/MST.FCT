using AutoMapper;
using Blazored.Modal;
using Blazored.Toast;
using FCT.Business.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MST.Core.Helpers.Configuration.Interfaces;
using MST.Core.Helpers.Services;
using MST.FCT.App.Server.Helpers;
using MST.FCT.App.Server.Services;
using MST.FCT.App.Server.Services.DataService;
using MST.FCT.Business.Services;
using System;

namespace MST.FCT.App.Server
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureRootConfiguration(Configuration);
            var rootConfiguration = services.BuildServiceProvider().GetService<IRootConfiguration>();

            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddBlazoredModal();
            services.AddBlazoredToast();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, options => {
                options.ExpireTimeSpan = new TimeSpan(3, 0, 0);
            })
            .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme,
            options =>
            {
                options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.Authority = "https://localhost:5001";
                options.ClientId = "fctserver";
                options.ClientSecret = "108B7B4F-BEFC-4DD2-82E1-7F025F0F75D0";
                options.ResponseType = "code";
                options.Scope.Add("openid");
                options.Scope.Add("profile");
                options.Scope.Add("email");
                options.Scope.Add("fctapi");
                options.Scope.Add("offline_access");
                options.Scope.Add("role");
                options.Scope.Add("country");
                options.SaveTokens = true;
                options.GetClaimsFromUserInfoEndpoint = true;
            });

            services.AddHttpClient<IAirportDataService, AirportDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:6001/");
            });
            services.AddHttpClient<ICountryDataService, CountryDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:6001/");
            });
            services.AddHttpClient<IUserDataService, UserDataService>(client =>
            {
                client.BaseAddress = new Uri("https://localhost:6001/");
            });

            //UserInfoService
            services.AddScoped<IUserInfoService, UserInfoService>();
            services.AddScoped<TokenProvider>();
            services.AddScoped<TokenManager>();
            services.AddAutoMapper(typeof(Startup));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
