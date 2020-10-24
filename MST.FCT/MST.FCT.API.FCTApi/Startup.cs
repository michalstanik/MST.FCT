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
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using MST.Core.Helpers.Configuration.Interfaces;
using MST.FCT.API.FCTApi.Helpers;
using MST.FCT.Business.Polices;
using MST.Flogging.Core.Filters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using MST.FCT.Business.Services.RequestHeaders;
using MST.Core.Helpers.Services;

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
            services.ConfigureRootConfiguration(Configuration);
            var rootConfiguration = services.BuildServiceProvider().GetService<IRootConfiguration>();

            var requireAuthenticatedUserPolicy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();

            services.AddAuthorization(authorizationOptions =>
            {
                authorizationOptions.AddPolicy(
                    AviationPolices.CanManageAirportsDictonary,
                    AviationPolices.CanManageAirportsDictonaryPolicy());
            });

            // register an IHttpContextAccessor so we can access the current HttpContext in services by injecting it
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddAutoMapper(typeof(Startup));

            #region Seeders
            services.AddTransient<DictionarySeeder>();
            services.AddTransient<EnsureDB>();
            #endregion Seeders

            #region Repositories
            services.AddScoped<IAviationRepository, AviationRepository>();
            services.AddScoped<IGeoRepository, GeoRepository>();
            #endregion Repositories

            //UserInfoService
            services.AddScoped<IUserInfoService, UserInfoService>();

            services.AddDbContext<FCTContext>(cfg =>
            {
                cfg.UseSqlServer(Configuration.GetConnectionString("FCTConnectionString"));
            });

            services.AddCors(options =>
            {
                options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
            });
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("FCTOpenAPISpecification",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "FCT API",
                        Version = "1"
                    });

                //setupAction.OperationFilter<TripOperationFilter>();
                //setupAction.OperationFilter<RegionOperationFilter>();
                //setupAction.OperationFilter<FlightOperationFilter>();

                setupAction.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme()
                {
                    Type = SecuritySchemeType.OAuth2,
                    Flows = new OpenApiOAuthFlows
                    {
                        Implicit = new OpenApiOAuthFlow
                        {
                            AuthorizationUrl = rootConfiguration.AuthConfiguration.STSApiAuthorizeUrl,
                            Scopes = new Dictionary<string, string>
                            {
                                { rootConfiguration.AuthConfiguration.STSApiName,
                                  rootConfiguration.AuthConfiguration.STSApiDescription
                                },
                            }
                        }
                    }
                });

                setupAction.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "oauth2" }
                        },
                        new[] { rootConfiguration.AuthConfiguration.STSApiName }
                    }
                });
                //Use of reflection to cobime a XML document with assembly path
                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlCommentFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);
                var xmlBussinessModelsPath = Path.Combine(AppContext.BaseDirectory, "MST.FCT.Business.Models.xml");

                setupAction.IncludeXmlComments(xmlCommentFullPath);
                setupAction.IncludeXmlComments(xmlBussinessModelsPath);
            });

            services.AddControllers(setupAction =>
            {
                setupAction.Filters.Add(new TrackPerformanceFilter());
                setupAction.Filters.Add(new AuthorizeFilter(requireAuthenticatedUserPolicy));

                setupAction.ReturnHttpNotAcceptable = true;

                var jsonOutputFormatter = setupAction.OutputFormatters.OfType<SystemTextJsonOutputFormatter>().FirstOrDefault();

                if (jsonOutputFormatter != null)
                {
                    //Airports
                    jsonOutputFormatter.SupportedMediaTypes.Add(AirportRequestHeaders.Airport);
                }
                var jsonInputFormatter = setupAction.InputFormatters.OfType<SystemTextJsonInputFormatter>().FirstOrDefault();
                if (jsonInputFormatter != null)
                {
                    if (jsonInputFormatter.SupportedMediaTypes.Contains("text/json"))
                    {
                        jsonInputFormatter.SupportedMediaTypes.Remove("text/json");
                    }
                }
            });

            services.AddAuthentication(IdentityServerAuthenticationDefaults.AuthenticationScheme)
            .AddIdentityServerAuthentication(options =>
            {
                //TODO: Move url to the config file 
                options.Authority = "https://localhost:5001/";
                options.ApiName = "fctapi";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var confScope = app.ApplicationServices.CreateScope();
            var rootConfiguration = confScope.ServiceProvider.GetService<IRootConfiguration>();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            #region SwagerUI
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(setupAction =>
            {
                setupAction.SwaggerEndpoint("/swagger/FCTOpenAPISpecification/swagger.json", "FCT API");
                setupAction.RoutePrefix = "api";

                setupAction.OAuthClientId(rootConfiguration.AuthConfiguration.STSOAuthClientId);
            });
            # endregion SwagerUI

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
