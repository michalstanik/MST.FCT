using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCT.Data.Domain.Geo
{
    public class Zone
    {
        public Zone()
        {
            TimeZones = new List<TimeZone>();
        }

        public int Id { get; set; }
        public int ZoneId { get; set; }
        public string CountryCode { get; set; }

        /// <summary>
        /// /Reference to Country
        /// </summary>
        public int CountryId {get;set;}
        public Country Country { get; set; }
        public string ZoneName { get; set; }

        public List<TimeZone> TimeZones { get; set; }
    }
}
