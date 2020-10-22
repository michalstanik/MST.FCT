using Blazored.Modal;
using FCT.Business.Services;
using Microsoft.AspNetCore.Components;
using MST.FCT.Business.Models.Aviation.Airport;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Pages.Airports
{
    public partial class DeleteAirportDialog : ComponentBase
    {
        [Inject]
        public IAirportDataService AirportDataService { get; set; }

        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        [Parameter] public int AirportId { get; set; }

        AirportModel Airport { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Airport = await AirportDataService.GetAirportById(AirportId);
        }

    }
}
