using IdentityModel.Client;
using MST.FCT.Business.Models.User.User;
using MST.FCT.Business.Services;
using MST.FCT.Business.Services.RequestHeaders;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Services.DataService
{
    public class UserDataService : IUserDataService
    {
        private readonly HttpClient _httpClient;
        private readonly TokenManager _tokenManager;

        public UserDataService(HttpClient httpClient, TokenManager tokenManager)
        {
            _httpClient = httpClient;
            _tokenManager = tokenManager;
        }
        public async Task<UserForCreationModel> AddUser(UserForCreationModel user)
        {
            _httpClient.SetBearerToken(await _tokenManager.RetrieveAccessTokenAsync());

            var userJson =
                new StringContent(JsonSerializer.Serialize(user), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/users", userJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<UserForCreationModel>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task<UserModel> GetUserById(string id)
        {
            HttpResponseMessage response = await GetUserForHeader(id, UserRequestHeaders.User);
            if(response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return new UserModel();
            }

            return await JsonSerializer.DeserializeAsync<UserModel>
                (await response.Content.ReadAsStreamAsync(), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        private async Task<HttpResponseMessage> GetUserForHeader(string id, string header)
        {
            _httpClient.SetBearerToken(await _tokenManager.RetrieveAccessTokenAsync());

            var request = new HttpRequestMessage(HttpMethod.Get, $"api/users/{id}");
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(header));

            var response = await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            //response.EnsureSuccessStatusCode();
            return response;
        }
    }
}
