// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IDP
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource("country", new [] { "country" }),
                new IdentityResource("role", "Roles", new[] {"role"})
            };

        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            {
                new ApiResource("fctapi",
                    "FCT: Flights Countries Travels API",
                    new [] { "country", "role" })
            };

        public static IEnumerable<Client> Clients =>
            new Client[]
            {
                new Client
                {
                    ClientId = "fctserver",
                    ClientName = "FCT: Flights Countries Travels App",
                    AllowOfflineAccess = true,
                    RequirePkce = true,
                    AccessTokenLifetime = 1200,
                    RequireConsent = false,
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = { new Secret("108B7B4F-BEFC-4DD2-82E1-7F025F0F75D0".Sha256()) },
                    RedirectUris = { "https://localhost:7001/signin-oidc" },
                    PostLogoutRedirectUris = { "https://localhost:7001/signout-callback-oidc" },
                    AllowedScopes = { "openid", "profile", "email", "fctapi", "country", "role" }
                },
                 new Client
                 {
                    ClientId = "fct_api_swagger",
                    ClientName = "Swagger UI for FCT",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    AllowAccessTokensViaBrowser = true,
                    RequireConsent = false,
                    AccessTokenLifetime = 180,
                    RedirectUris = { "https://localhost:6001/api/oauth2-redirect.html" },
                    AllowedScopes = new []
                    {
                        "fctapi"
                    }
                }
            };

    }
}