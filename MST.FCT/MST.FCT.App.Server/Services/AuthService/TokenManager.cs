﻿using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Services
{
    public class TokenManager
    {
        private readonly TokenProvider _tokenProvider;
        private readonly IHttpClientFactory _httpClientFactory;

        public TokenManager(TokenProvider tokenProvider,
            IHttpClientFactory httpClientFactory)
        {
            _tokenProvider = tokenProvider ??
                throw new ArgumentNullException(nameof(tokenProvider));
            _httpClientFactory = httpClientFactory ??
                throw new ArgumentNullException(nameof(httpClientFactory));
        }

        public async Task<string> RetrieveAccessTokenAsync()
        {
            // should we refresh? 

            if ((_tokenProvider.ExpiresAt.AddSeconds(-60)).ToUniversalTime()
                    > DateTime.UtcNow)
            {
                // no need to refresh, return the access token
                return _tokenProvider.AccessToken;
            }

            // refresh
            var idpClient = _httpClientFactory.CreateClient();

            //TODO: Move host to the configuration
            var discoveryReponse = await idpClient
                .GetDiscoveryDocumentAsync("https://localhost:5001");

            var refreshResponse = await idpClient.RequestRefreshTokenAsync(
               new RefreshTokenRequest
               {
                   Address = discoveryReponse.TokenEndpoint,
                   ClientId = "fctserver",
                   ClientSecret = "108B7B4F-BEFC-4DD2-82E1-7F025F0F75D0",
                   RefreshToken = _tokenProvider.RefreshToken
               });

            _tokenProvider.AccessToken = refreshResponse.AccessToken;
            _tokenProvider.RefreshToken = refreshResponse.RefreshToken;
            _tokenProvider.ExpiresAt = DateTime.UtcNow.AddSeconds(refreshResponse.ExpiresIn);

            return _tokenProvider.AccessToken;
        }
    }
}
