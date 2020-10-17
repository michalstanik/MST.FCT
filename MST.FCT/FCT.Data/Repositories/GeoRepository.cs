using FCT.Data.Domain.Geo;
using FCT.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCT.Data.Repositories
{
    public class GeoRepository : IGeoRepository
    {
        private readonly FCTContext _context;

        public GeoRepository(FCTContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Country>> GetAllCountriesAsync()
        {
            return await _context.Country.Include(c => c.Region)
                .ThenInclude(c => c.Continent)
                .ToListAsync();
        }

        public async Task<Country> GetCountryByIdAsync(int id)
        {
            return await _context.Country.Include(c => c.Region)
                .ThenInclude(c => c.Continent)
                .Where(c => c.Id == id)
                .FirstOrDefaultAsync();
        }
    }
}
