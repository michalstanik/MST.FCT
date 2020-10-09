namespace MST.Core.Helpers.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        IAuthConfiguration AuthConfiguration { get; }
        IAppConfiguration AppConfiguration { get; }
        IIntegratedEnv IntegratedEnv { get; }
    }
}
