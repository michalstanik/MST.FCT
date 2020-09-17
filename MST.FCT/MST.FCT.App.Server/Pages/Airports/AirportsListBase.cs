using FCT.Business.Models.Aviation.Airport;
using FCT.Business.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MST.FCT.App.Server.Pages.Airports
{
    public class AirportsListBase : ComponentBase
    {
        [Inject]
        public IAirportDataService AirportDataService { get; set; }

        public List<AirportModel> Airports { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Airports = (await AirportDataService.GetAllAirports()).ToList(); 
        }
    }
}
