using FCT.Data.Domain.Geo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FCT.Data.IRepositories
{
    public interface IGeoRepository
    {
        Task<Country> GetCountryByIdAsync(int id);
        Task<IEnumerable<Country>> GetAllCountriesAsync();
    }
}
