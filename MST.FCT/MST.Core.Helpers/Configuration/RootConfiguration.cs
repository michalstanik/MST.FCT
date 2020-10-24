using Microsoft.Extensions.Options;
using MST.Core.Helpers.Configuration.Interfaces;

namespace MST.Core.Helpers.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public IAuthConfiguration AuthConfiguration { get; set; }

        public IAppConfiguration AppConfiguration { get; set; }

        public IIntegratedEnv IntegratedEnv { get; set; }

        public RootConfiguration(
            IOptions<AuthConfiguration> authConfiguration,
            IOptions<AppConfiguration> appConfiguration,
            IOptions<IntegratedEnv> integConfiguration
            )
        {
            AuthConfiguration = authConfiguration.Value;
            AppConfiguration = appConfiguration.Value;
            IntegratedEnv = integConfiguration.Value;
        }
    }
}
