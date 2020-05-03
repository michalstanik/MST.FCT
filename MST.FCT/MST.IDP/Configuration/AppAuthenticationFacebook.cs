using MST.IDP.Configuration.Interfaces;

namespace MST.IDP.Configuration
{
    public class AppAuthenticationFacebook : IAppAuthenticationFacebook
    {
        public string AppId { get; set; }

        public string AppSecret { get; set; }
    }
}
