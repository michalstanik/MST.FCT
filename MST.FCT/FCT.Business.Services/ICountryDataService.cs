using MST.FCT.Business.Models.Geo.Country;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MST.FCT.Business.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<CountryModel>> GetAllCountries();
    }
}
