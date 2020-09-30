using FCT.Data.Domain.Flights;
using FCT.Data.Domain.Geo;
using System.Collections.Generic;

namespace FCT.Data.Domain.Aviation
{
    public class Airline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }

        public int? AirlineCountryId { get; set; }
        public Country AirlineCountry { get; set; }

        public int? AirLineAllianceId { get; set; }
        public AirlineAlliance AirLineAlliance { get; set; }

        public List<Flight> Flights { get; set; }
    }
}
