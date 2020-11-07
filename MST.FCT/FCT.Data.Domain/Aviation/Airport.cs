using FCT.Data.Domain.Flights;
using FCT.Data.Domain.Geo;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FCT.Data.Domain.Aviation
{
    public class Airport
    {
        public Airport()
        {
            ArrivalFlights = new List<Flight>();
            DepartureFlights = new List<Flight>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryCode { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Elevation { get; set; }

        public int? CountryId { get; set; }
        public Country Country { get; set; }

        public string TimeZone { get; set; }

        [InverseProperty("ArrivalAirport")]
        public List<Flight> ArrivalFlights { get; set; }

        [InverseProperty("DepartureAirport")]
        public List<Flight> DepartureFlights { get; set; }
    }
}
