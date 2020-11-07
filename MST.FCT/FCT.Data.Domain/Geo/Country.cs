using FCT.Data.Domain.Aviation;
using System.Collections.Generic;

namespace FCT.Data.Domain.Geo
{
    public class Country
    {
        public Country()
        {
            Airports = new List<Airport>();
            Zones = new List<Zone>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string OfficialName { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public long Area { get; set; }

        public int? RegionId { get; set; }
        public Region Region { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public List<Airport> Airports { get; }
        public List<Zone> Zones { get; set; }
    }
}