using System;

namespace MST.Core.Helpers.Configuration.Interfaces
{
    public interface IAuthConfiguration
    {
        string STSAuthority { get; }
        string STSApiName { get; }
        Uri STSApiAuthorizeUrl { get; }
        string STSOAuthClientId { get; }
        string STSApiDescription { get; }
    }
}
