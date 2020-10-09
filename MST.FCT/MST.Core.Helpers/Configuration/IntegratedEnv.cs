using MST.Core.Helpers.Configuration.Interfaces;
using System;

namespace MST.Core.Helpers.Configuration
{
    public class IntegratedEnv : IIntegratedEnv
    {
        public Uri UrlCodeSource { get; set; }
        public Uri UrlIDPMain { get; set; }
        public Uri UrlApiSpec { get; set; }
    }
}
