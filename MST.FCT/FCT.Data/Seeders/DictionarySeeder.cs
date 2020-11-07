using FCT.Data.Seeders.Dictionaries;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace FCT.Data.Seeders
{
    public class DictionarySeeder
    {
        private readonly FCTContext _context;
        private readonly ILogger<DictionarySeeder> _logger;

        public DictionarySeeder(FCTContext context, ILogger<DictionarySeeder> logger)
        {
            _context = context;
            _logger = logger;
        }
        public void Seed()
        {
            _context.Database.Migrate();

            CountriesSeederJson.SeedCountries(_context, _logger);
            TimeZoneSeederCSV.SeedZones(_context, _logger);    
            AirportsSeederJson.SeedAirports(_context, _logger);
        }
    }
}