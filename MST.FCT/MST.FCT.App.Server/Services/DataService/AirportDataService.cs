﻿using FCT.Business.Services;
using IdentityModel.Client;
using MST.FCT.Business.Models.Aviation.Airport;
using MST.FCT.Business.Services.RequestHeaders;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

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

        public async Task<AirportModel> AddAirport(AirportModel airport)
        {
            _httpClient.SetBearerToken(await _tokenManager.RetrieveAccessTokenAsync());

            var employeeJson =
                new StringContent(JsonSerializer.Serialize(airport), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/airports", employeeJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<AirportModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task<AirportModel> GetAirportById(int id)
        {
            HttpResponseMessage response = await GetAirportForHeader(id, AirportRequestHeaders.Airport);

            return await JsonSerializer.DeserializeAsync<AirportModel>
                (await response.Content.ReadAsStreamAsync(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<AirportWithFlightsModel> GetAirportWithFlightsById(int id)
        {
            HttpResponseMessage response = await GetAirportForHeader(id, AirportRequestHeaders.AirportWithFlights);

            return await JsonSerializer.DeserializeAsync<AirportWithFlightsModel>
                (await response.Content.ReadAsStreamAsync(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<IEnumerable<AirportModel>> GetAllAirports()
        {
            _httpClient.SetBearerToken(await _tokenManager.RetrieveAccessTokenAsync());

            var request = new HttpRequestMessage(HttpMethod.Get, $"api/airports");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(AirportRequestHeaders.Airport));

            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            return await JsonSerializer.DeserializeAsync<IEnumerable<AirportModel>>
                (await response.Content.ReadAsStreamAsync(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        private async Task<HttpResponseMessage> GetAirportForHeader(int id, string header)
        {
            _httpClient.SetBearerToken(await _tokenManager.RetrieveAccessTokenAsync());

            var request = new HttpRequestMessage(HttpMethod.Get, $"api/airports/{id}");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(header));

            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            return response;
        }
    }
}
