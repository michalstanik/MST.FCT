using CsvHelper;
using FCT.Data.Domain.Geo;
using FCT.Data.Seeders.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using TimeZoneNames;

namespace FCT.Data.Seeders.Dictionaries
{
    public static class TimeZoneSeederCSV
    {

        public static void SeedZones(FCTContext _context, ILogger<DictionarySeeder> logger)
        {
            logger.LogInformation("Start Zone Seeder", DateTime.Now);

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
                        GenericZoneName = TZNames.GetNamesForTimeZone(record.ZoneName, "en-US").Generic,
                        Country = _createdCountries.Where(c => c.Alpha2Code == record.CountryCode).FirstOrDefault() 
                    });
                }

                _context.AddRange(zoneList);
                _context.SaveChanges();
            }

            logger.LogInformation("Finished Zone Seeder", DateTime.Now);
        }

        public static void SeedTimeZones(FCTContext _context, ILogger<DictionarySeeder> logger)
        {
            logger.LogInformation("Start TimeZone Seeder", DateTime.Now);

            if (_context.TimeZone.Any()) return;

            var zonesFilePath = Path.Combine(AppContext.BaseDirectory, "LoadData\\timezone.csv");

            var _createdZones = _context.Zone.ToList();
            var zoneList = new List<Domain.Geo.TimeZone>();


            using (var reader = new StreamReader(zonesFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = false;
                var records = csv.GetRecords<TimeZoneModel>();

                foreach (var record in records)
                {
                    zoneList.Add(new Domain.Geo.TimeZone()
                    {
                        ZoneId = _createdZones.Where(c => c.ZoneId == record.Id).Select(i => i.Id).FirstOrDefault(),
                        Abbreviation = record.Abbreviation,
                        TimeStart = record.TimeStart,
                        GMTOffset = record.GMTOffset,
                        Dst = record.Dst
                    });
                }

                _context.AddRange(zoneList);
                _context.SaveChanges();
            }

            logger.LogInformation("Finished TimeZone Seeder", DateTime.Now);
        }
    }
}
