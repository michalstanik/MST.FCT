using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCT.Data.Domain.Geo
{
    public class Zone
    {
        public Zone()
        {
            TimeZones = new List<ZoneTimeZone>();
        }

        public int Id { get; set; }
        public string CountryCode { get; set; }

        /// <summary>
        /// /Reference to Country
        /// </summary>
        public int CountryId {get;set;}
        public Country Country { get; set; }
        public string ZoneName { get; set; }
        public string GenericZoneName { get; set; }

        public List<ZoneTimeZone> TimeZones { get; set; }
    }
}
