using MST.FCT.Business.Models.Aviation.Airport;
using FCT.Business.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using IdentityModel.Client;

namespace MST.FCT.App.Server.Services.DataService
{
    public class AirportDataService : IAirportDataService
    {
        private readonly HttpClient _httpClient;
        private readonly TokenManager _tokenManager;

        public AirportDataService(HttpClient httpClient, TokenManager tokenManager)
        {
            _httpClient = httpClient;
            _tokenManager = tokenManager;
        }

        public async Task<IEnumerable<AirportModel>> GetAllAirports()
        {
            _httpClient.SetBearerToken(await _tokenManager.RetrieveAccessTokenAsync());

            return await JsonSerializer.DeserializeAsync<IEnumerable<AirportModel>>
                (await _httpClient.GetStreamAsync($"api/airports"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
