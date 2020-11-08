using CsvHelper;
using FCT.Data.Domain.Geo;
using FCT.Data.Seeders.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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
            logger.LogInformation("DB Seeder: Zones", DateTime.Now);

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
                        CountryCode = record.CountryCode,
                        ZoneName = record.ZoneName,
                        GenericZoneName = TZNames.GetNamesForTimeZone(record.ZoneName, "en-US").Generic,
                        Country = _createdCountries.Where(c => c.Alpha2Code == record.CountryCode).FirstOrDefault()
                    });
                }

                _context.AddRange(zoneList);
                _context.SaveChanges();
            }
        }

        public static void SeedTimeZones(FCTContext _context, ILogger<DictionarySeeder> logger)
        {
            logger.LogInformation("DB Seeder: TimeZones", DateTime.Now);

            if (_context.TimeZone.Any()) return;

            var zones = _context.Zone.ToList();

            var timeZonesFilePath = Path.Combine(AppContext.BaseDirectory, "LoadData\\timezones.json");

            using (StreamReader r = new StreamReader(timeZonesFilePath))
            {
                var settings = new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    MissingMemberHandling = MissingMemberHandling.Ignore
                };

                string json = r.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<TimeZoneModel>>(json, settings);

                var timeZones = new List<Domain.Geo.TimeZone>();
                var zoneTimeZones = new List<ZoneTimeZone>();

                foreach (var item in items)
                {
                    var timeZone = new Domain.Geo.TimeZone()
                    {
                        Name = item.value,
                        Abbreviation = item.abbr,
                        IsDst = item.isdst,
                        Description = item.text,
                        Offset = item.offset
                    };

                    foreach (var ztz in item.utc)
                    {
                        var zone = zones.Where(z => z.ZoneName == ztz).FirstOrDefault();
                        if (zone != null)
                        {
                            timeZone.Zones.Add(new ZoneTimeZone() { TimeZone = timeZone, Zone = zone });
                        }
                    }

                    timeZones.Add(timeZone);
                }
                _context.TimeZone.AddRange(timeZones);
                _context.SaveChanges();

            }
        }
    }
}