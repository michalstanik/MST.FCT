using MST.FCT.Business.Models.Aviation.Airport;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FCT.Business.Services
{
    public interface IAirportDataService
    {
        Task<IEnumerable<AirportModel>> GetAllAirports();
        Task<AirportModel> AddAirport(AirportModel airport);
    }
}
