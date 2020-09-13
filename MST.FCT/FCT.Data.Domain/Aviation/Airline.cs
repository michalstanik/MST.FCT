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
        //TODO: Enable countries
        //public Country AirlineCountry { get; set; }

        public int? AirLineAllianceId { get; set; }
        public AirlineAlliance AirLineAlliance { get; set; }

        //TODO: Enable when flight will avaliable
        //public List<Flight> Flights { get; set; }
    }
}
