using FCT.Data.Domain.Geo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static FCT.Data.Seeders.Models.CountriesModel;

namespace FCT.Data.Seeders.Dictionaries
{
    public static class CountriesSeederJson
    {
        public static void SeedCountries(FCTContext _context)
        {
            if (_context.Country.Any()) return;

            var countriesFilePath = Path.Combine(AppContext.BaseDirectory, "LoadData\\countries.json");

            using (StreamReader r = new StreamReader(countriesFilePath))
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                string json = r.ReadToEnd();
                List<CountriesDataModel> items = JsonConvert.DeserializeObject<List<CountriesDataModel>>(json, settings);
                foreach (var item in items)
                {
                    var continent = new Continent();

                    var existingContinent = _context.Continent.Where(c => c.Name == item.region).FirstOrDefault();

                    if (existingContinent == null)
                    {
                        continent = new Continent() { Name = item.region };
                        _context.Add(continent);
                        _context.SaveChanges();
                    }
                    else
                    {
                        continent = existingContinent;
                    }

                    var region = new Region();
                    var existingRegion = _context.Region.Where(rg => rg.Name == item.subregion).FirstOrDefault();

                    if (existingRegion == null)
                    {
                        region = new Region() { Name = item.subregion, Continent = continent };
                        _context.Add(region);
                        _context.SaveChanges();
                    }
                    else
                    {
                        region = existingRegion;
                    }

                    var newCountry = new Country()
                    {
                        Name = item.name.common,
                        OfficialName = item.name.official,
                        Alpha2Code = item.cca2,
                        Alpha3Code = item.cca3,
                        Area = item.area,
                        Region = region,
                        Latitude = item.latlng.FirstOrDefault(),
                        Longitude = item.latlng.LastOrDefault()
                    };
                    _context.Add(newCountry);
                    _context.SaveChanges();
                }
            }

        }
    }
}
