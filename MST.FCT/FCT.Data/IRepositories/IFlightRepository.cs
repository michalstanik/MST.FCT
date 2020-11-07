using FCT.Data.Domain.Flights;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FCT.Data.IRepositories
{
    public interface IFlightRepository
    {
        Task<IEnumerable<Flight>>GetAllFlightsForUserAsync(string userId);
    }
}
