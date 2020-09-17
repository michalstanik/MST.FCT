using FCT.Data.Domain.Aviation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FCT.Data.IRepositories
{
    public interface IAviationRepository
    {
        Task<IEnumerable<Airport>> GetAllAirportsAsync();
    }
}
