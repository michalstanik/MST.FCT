using MST.Core.Helpers.Configuration.Interfaces;

namespace MST.Core.Helpers.Configuration
{
    public class AppConfiguration : IAppConfiguration
    {
        public bool RecreateDB { get; set; }

        public bool DeleteData { get; set; }

        public double RemoveLogsOlderThanHours { get; set; }
    }
}
