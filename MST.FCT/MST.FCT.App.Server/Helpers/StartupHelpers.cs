using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MST.Core.Helpers.Configuration;
using MST.Core.Helpers.Configuration.Constants;
using MST.Core.Helpers.Configuration.Interfaces;

namespace MST.FCT.App.Server.Helpers
{
    public static class StartupHelpers
    {
        /// <summary>
        /// Configuration root configuration
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection ConfigureRootConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddOptions();

            services.Configure<AuthConfiguration>(configuration.GetSection(ConfigurationConsts.AuthConfigurationKey));
            services.Configure<AppConfiguration>(configuration.GetSection(ConfigurationConsts.AppConfigurationKey));
            services.Configure<IntegratedEnv>(configuration.GetSection(ConfigurationConsts.IntegConfigurationKey));
            services.TryAddSingleton<IRootConfiguration, RootConfiguration>();
            return services;
        }
    }
}
