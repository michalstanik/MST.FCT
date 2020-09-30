using FCT.Data.Domain.Aviation;
using FCT.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
        public async Task<IEnumerable<Airport>> GetAllAirportsAsync()
        {
            return await _context.Airport.Include(c=> c.Country).ToListAsync();
        }
    }
}
