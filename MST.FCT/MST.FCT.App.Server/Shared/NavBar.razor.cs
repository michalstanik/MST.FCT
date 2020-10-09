using Microsoft.AspNetCore.Components;
using MST.Core.Helpers.Configuration.Interfaces;
using System;

namespace MST.FCT.App.Server.Shared
{
    public partial class NavBar : ComponentBase
    {
        [Inject]
        IRootConfiguration rootConfiguration { get; set; }

        public Uri UrlApiSpec { get => rootConfiguration.IntegratedEnv.UrlApiSpec; }
        public Uri UrlIdpMain { get => rootConfiguration.IntegratedEnv.UrlIDPMain; }
        public Uri UrlGit { get => rootConfiguration.IntegratedEnv.UrlCodeSource; }
    }
}
