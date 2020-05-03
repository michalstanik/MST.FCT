namespace MST.IDP.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        IAppConfiguration AppConfiguration { get; }
        IEmailConfiguration EmailConfiguration { get; }
        IAppAuthenticationFacebook AppAuthenticationFacebook { get; }
    }
}
