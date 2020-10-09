﻿namespace MST.Core.Helpers.Configuration.Interfaces
{
    public interface IAppConfiguration
    {
        bool RecreateDB { get; }
        bool DeleteData { get; }
        double RemoveLogsOlderThanHours { get; }
    }
}
