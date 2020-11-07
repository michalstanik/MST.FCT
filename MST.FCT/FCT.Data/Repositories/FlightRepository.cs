using FCT.Data.Domain.Flights;
using FCT.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FCT.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private readonly FCTContext _context;

        public FlightRepository(FCTContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Flight>> GetAllFlightsForUserAsync(string userId)
        {
            var flightQuery = _context.UserFlight.Where(u => u.TUserId == userId).Select(f => f.Flight);

            flightQuery = flightQuery.Include(i => i.Aircraft)
                                     .Include(t => t.Airline)
                                     .Include(a => a.ArrivalAirport)
                                     .Include(b => b.DepartureAirport);
            
            return await flightQuery.ToListAsync();                         
        }
    }
}
