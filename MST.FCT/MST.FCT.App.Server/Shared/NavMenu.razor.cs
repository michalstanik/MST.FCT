using Microsoft.AspNetCore.Components;
using MST.Core.Helpers.Configuration.Interfaces;

namespace MST.FCT.App.Server.Shared
{
    public partial class NavManu : ComponentBase
    {
        private readonly IRootConfiguration _conf;

        public NavManu(IRootConfiguration conf)
        {
            _conf = conf;
        }
    }
}
