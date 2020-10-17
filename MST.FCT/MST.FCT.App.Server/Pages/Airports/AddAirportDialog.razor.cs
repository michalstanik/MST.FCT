using Blazored.Modal;
using FCT.Business.Services;
using Microsoft.AspNetCore.Components;
using MST.FCT.Business.Models.Aviation.Airport;
using MST.FCT.Business.Models.Geo.Country;
using MST.FCT.Business.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MST.FCT.App.Server.Pages.Airports
{
    public partial class AddAirportDialog : ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance BlazoredModal { get; set; }

        [Inject]
        public ICountryDataService CountryDataService { get; set; }
        [Inject]
        public IAirportDataService AirportDataService { get; set; }

        public List<CountryModel> Countries { get; set; }

        public AirportModel Airport { get; set; } = new AirportModel();

        protected override async Task OnInitializedAsync()
        {
            Countries = (await CountryDataService.GetAllCountries()).ToList();
        }
        protected async Task HandleValidSubmit()
        {
            await AirportDataService.AddAirport(Airport);

            //await CloseEventCallback.InvokeAsync(true);
            StateHasChanged();
        }
    }
}
