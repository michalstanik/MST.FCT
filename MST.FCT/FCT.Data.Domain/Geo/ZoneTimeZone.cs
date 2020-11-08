namespace FCT.Data.Domain.Geo
{
    public class ZoneTimeZone
    {
        public int ZoneId { get; set; }
        public Zone Zone { get; set; }
        public int TimeZoneId { get; set; }
        public TimeZone TimeZone { get; set; }
    }
}
