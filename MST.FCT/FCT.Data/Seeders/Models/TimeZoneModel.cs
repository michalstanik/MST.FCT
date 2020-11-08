using System.Collections.Generic;

namespace FCT.Data.Seeders.Models
{
    public class TimeZoneModel
    {
#pragma warning disable IDE1006 // Naming Styles
        public string value { get; set; }
        public string abbr { get; set; }
        public long offset { get; set; }
        public bool isdst { get; set; }
        public string text { get; set; }
        public List<string> utc { get; set; }
#pragma warning restore IDE1006 // Naming Styles
    }
}
