using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MST.IDP.Configuration;
using MST.IDP.Configuration.Constants;
using MST.IDP.Configuration.Interfaces;

namespace MST.IDP.Helpers
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

            services.Configure<AppConfiguration>(configuration.GetSection(ConfigurationConsts.AppConfigurationKey));
            services.Configure<EmailConfiguration>(configuration.GetSection(ConfigurationConsts.EmailConfigurationKey));

            services.TryAddSingleton<IRootConfiguration, RootConfiguration>();
            return services;
        }
    }
}
