﻿using FCT.Data.Seeders.Dictionaries;
using Microsoft.EntityFrameworkCore;

namespace FCT.Data.Seeders
{
    public class DictionarySeeder
    {
        private readonly FCTContext _context;
        public DictionarySeeder(FCTContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            _context.Database.Migrate();

            CountriesSeederJson.SeedCountries(_context);
            AirportsSeederJson.SeedAirports(_context);
        }
    }
}