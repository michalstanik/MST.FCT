using MST.FCT.Business.Models.Aviation.Airport;
using FCT.Business.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Pages.Airports
{
    public partial class AirportsList : ComponentBase
    {
        [Inject]
        public IAirportDataService AirportDataService { get; set; }

        public List<AirportModel> Airports { get; set; }


        public AirportModel SelectedAirport { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Airports = (await AirportDataService.GetAllAirports()).ToList();
            Airports = Airports.Where(c => !string.IsNullOrWhiteSpace(c.IATA)).ToList();
        }
        private void GridSelectionChanged(AirportModel airport)
        {
            SelectedAirport = airport;
        }

        private void IncludeIcao()
        {

        }
    }
}
