using System;

namespace MST.Core.Helpers.Configuration.Interfaces
{
    public interface IIntegratedEnv
    {
        Uri UrlCodeSource { get; set; }
        Uri UrlIDPMain { get; set; }
        Uri UrlApiSpec { get; set; }
    }
}
