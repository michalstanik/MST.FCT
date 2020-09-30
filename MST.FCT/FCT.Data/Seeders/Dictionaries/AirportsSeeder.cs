using FCT.Data.Domain.Aviation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FCT.Data.Seeders.Dictionaries
{
    public static class AirportsSeeder
    {
        public static void SeedAirports(FCTContext _context)
        {
            if (_context.Airport.Any()) return;

            var airportsFilePath = Path.Combine(AppContext.BaseDirectory, "LoadData\\airports.dat.txt");

            using (var reader = new StreamReader(airportsFilePath))
            {
                var listOfAirports = new List<Airport>();
                var countriesDictonary = new Dictionary<int, string>();
                foreach (var country in _context.Country.ToList())
                {
                    countriesDictonary.Add(country.Id, country.Name);
                }

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine().Replace("\"", "");
                    var values = line.Split(',');

                    var airport = new Airport()
                    {
                        AirportId = values[0],
                        Name = values[1],
                        City = values[2],
                        CountryName = values[3],
                        IATA = values[4],
                        ICAO = values[5]
                        //TODO: Fix an convert issue for airport latitude and longitude
                        //Latitude = Convert.ToInt64(values[6]),
                        //Longitude = Convert.ToInt64(values[7])
                    };

                    switch (values[3])
                    {
                        case "Reunion":
                            values[3] = "Réunion";
                            break;
                        case "Burma":
                            values[3] = "Myanmar";
                            break;
                        case "Congo (Brazzaville)":
                            values[3] = "DR Congo";
                            break;
                        case "Congo (Kinshasa)":
                            values[3] = "DR Congo";
                            break;
                        case "Czech Republic":
                            values[3] = "Czechia";
                            break;
                    }

                    var countryId = countriesDictonary.Where(c => c.Value == values[3]).Select(c => c.Key).FirstOrDefault();
                    if (countryId != 0)
                    {
                        airport.CountryId = countryId;
                    }

                    listOfAirports.Add(airport);
                }
                _context.AddRange(listOfAirports);
                _context.SaveChanges();
            }
        }
    }
}
