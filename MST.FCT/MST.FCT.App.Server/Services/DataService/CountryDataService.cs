using IdentityModel.Client;
using MST.FCT.Business.Models.Geo.Country;
using MST.FCT.Business.Services;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Services.DataService
{
    public class CountryDataService : ICountryDataService
    {
        private readonly HttpClient _httpClient;
        private readonly TokenManager _tokenManager;

        public CountryDataService(HttpClient httpClient, TokenManager tokenManager)
        {
            _httpClient = httpClient;
            _tokenManager = tokenManager;
        }

        public async Task<IEnumerable<CountryModel>> GetAllCountries()
        {
            _httpClient.SetBearerToken(await _tokenManager.RetrieveAccessTokenAsync());

            return await JsonSerializer.DeserializeAsync<IEnumerable<CountryModel>>
                (await _httpClient.GetStreamAsync($"api/countries"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }
}
