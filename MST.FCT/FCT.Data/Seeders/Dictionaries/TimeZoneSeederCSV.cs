using CsvHelper;
using FCT.Data.Domain.Geo;
using FCT.Data.Seeders.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;


namespace FCT.Data.Seeders.Dictionaries
{
    public static class TimeZoneSeederCSV
    {

        public static void SeedZones(FCTContext _context, ILogger<DictionarySeeder> logger)
        {
            logger.LogInformation("Start TimeZone Seeder", DateTime.Now);

            if (_context.Zone.Any()) return;

            var zonesFilePath = Path.Combine(AppContext.BaseDirectory, "LoadData\\zone.csv");

            var _createdCountries = _context.Country.ToList();
            var zoneList = new List<Zone>();


            using (var reader = new StreamReader(zonesFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                var records = csv.GetRecords<ZoneModel>();

                foreach (var record in records)
                {
                    zoneList.Add(new Zone()
                    {
                        ZoneId = record.Id,
                        CountryCode = record.CountryCode,
                        ZoneName = record.ZoneName,
                        Country = _createdCountries.Where(c => c.Alpha2Code == record.CountryCode).FirstOrDefault()
                    });
                }

                _context.AddRange(zoneList);
                _context.SaveChanges();
            }

            logger.LogInformation("Finished TimeZone Seeder", DateTime.Now);
        }
    }
}
