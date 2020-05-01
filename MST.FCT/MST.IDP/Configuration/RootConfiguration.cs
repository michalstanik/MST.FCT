using Microsoft.Extensions.Options;
using MST.IDP.Configuration.Interfaces;

namespace MST.IDP.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {
        public IAppConfiguration AppConfiguration { get; set; }
        public IEmailConfiguration EmailConfiguration { get; set; }

        public RootConfiguration(IOptions<EmailConfiguration> emailConfiguration, IOptions<AppConfiguration> appConfiguration)
        {
            EmailConfiguration = emailConfiguration.Value;
        }
    }
}
