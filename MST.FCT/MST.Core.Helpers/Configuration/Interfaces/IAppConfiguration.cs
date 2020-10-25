namespace MST.Core.Helpers.Configuration.Interfaces
{
    public interface IAppConfiguration
    {
        bool RecreateDB { get; }
        double RemoveLogsOlderThanHours { get; }
    }
}
