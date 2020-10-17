using FCT.Data.Domain.Aviation;
using FCT.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCT.Data.Repositories
{
    public class AviationRepository : IAviationRepository
    {
        private readonly FCTContext _context;

        public AviationRepository(FCTContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Airport> AddAirportAsync(Airport airport)
        {
            var addedEntity = _context.Airport.Add(airport);
            await _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<Airport> GetAiportByIdAsync(int id)
        {
            return await _context.Airport
                .Include(c => c.Country).Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Airport>> GetAllAirportsAsync()
        {
            return await _context.Airport.Include(c=> c.Country).ToListAsync();
        }
    }
}
