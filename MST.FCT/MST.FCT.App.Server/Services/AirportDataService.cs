using FCT.Business.Models.Aviation.Airport;
using FCT.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Services
{
    public class AirportDataService : IAirportDataService
    {
        private readonly HttpClient _httpClient;

        public AirportDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<AirportModel>> GetAllAirports()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<AirportModel>>
                (await _httpClient.GetStreamAsync($"api/airports"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
