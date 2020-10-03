using FCT.Data.Domain.Aviation;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FCT.Data.Seeders.Models.AirportsModel;

namespace FCT.Data.Seeders.Dictionaries
{
    public static class AirportsSeederJson
    {
        public static void SeedAirports(FCTContext _context)
        {
            if (_context.Airport.Any()) return;

            var countriesFilePath = Path.Combine(AppContext.BaseDirectory, "LoadData\\airports.json");

            using (StreamReader r = new StreamReader(countriesFilePath))
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<Dictionary<string, AirportModel>>(json, settings);

                var airportsList = new List<Airport>();
                
                foreach (var item in items)
                {
                    var countryCode = item.Value.country;
                    var airport = new Airport()
                    {
                        Name = item.Value.name,
                        CountryCode = item.Value.country,
                        Country = _context.Country.Where(c => c.Alpha2Code == countryCode).FirstOrDefault(),
                        State = item.Value.state,
                        City = item.Value.city,
                        IATA = item.Value.iata,
                        ICAO = item.Value.icao,
                        Latitude = item.Value.lat,
                        Longitude = item.Value.lon,
                        Elevation = item.Value.elevation
                    };
                    airportsList.Add(airport);
                }
                _context.Airport.AddRange(airportsList);
                _context.SaveChanges();
            }
        }
    }
}
