using MST.IDP.Configuration.Interfaces;

namespace MST.IDP.Configuration
{
    public class EmailConfiguration : IEmailConfiguration
    {
        public bool Active { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
    }
}
