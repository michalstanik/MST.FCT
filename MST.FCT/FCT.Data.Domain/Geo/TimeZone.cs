using System.Collections.Generic;

namespace FCT.Data.Domain.Geo
{
    public class TimeZone
    {
        public TimeZone()
        {
            Zones = new List<ZoneTimeZone>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Abbreviation { get; set; }
        public long Offset { get; set; }
        public bool IsDst { get; set; }
        public string  Description { get; set; }

        public List<ZoneTimeZone> Zones { get; set; }
    }
}
