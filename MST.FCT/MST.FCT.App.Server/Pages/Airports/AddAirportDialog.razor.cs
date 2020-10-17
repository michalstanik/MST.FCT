using Blazored.Modal;
using Microsoft.AspNetCore.Components;
using MST.FCT.App.Server.Services.DataService;
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

        public List<CountryModel> Countries { get; set; }

        public AirportModel Airport { get; set; } = new AirportModel();

        public bool ShowDialog { get; set; }

        public void Show()
        {
           // ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        protected override async Task OnInitializedAsync()
        {
            Countries = (await CountryDataService.GetAllCountries()).ToList();
        }
    }
}
