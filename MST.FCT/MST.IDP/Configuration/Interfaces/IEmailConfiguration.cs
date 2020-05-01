namespace MST.IDP.Configuration.Interfaces
{
    public interface IEmailConfiguration
    {
        bool Active { get; }
        string Email { get; }
        string Password { get; }
        string Host { get; }
        string Port { get; }
    }
}

