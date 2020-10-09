using MST.Core.Helpers.Configuration.Interfaces;
using System;

namespace MST.Core.Helpers.Configuration
{
    public class AuthConfiguration : IAuthConfiguration
    {
        public string STSAuthority { get; set; }
        public string STSApiName { get; set; }
        public Uri STSApiAuthorizeUrl { get; set; }
        public string STSOAuthClientId { get; set; }
        public string STSApiDescription { get; set; }
    }
}
