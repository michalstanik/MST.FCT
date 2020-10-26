using FCT.Data.Domain.Aviation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FCT.Data.IRepositories
{
    public interface IAviationRepository
    {
        Task<Airport> GetAiportByIdAsync(int id, bool includeFlights = false);
        Task<IEnumerable<Airport>> GetAllAirportsAsync();
        Task<Airport> AddAirportAsync(Airport airport);
        Task DeleteAirportAsync(int id);
    }
}
