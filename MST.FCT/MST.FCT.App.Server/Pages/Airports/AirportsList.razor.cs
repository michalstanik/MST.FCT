using MST.FCT.Business.Models.Aviation.Airport;
using FCT.Business.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Blazored.Modal;
using Blazored.Modal.Services;
using MST.Core.Helpers.Services;

namespace MST.FCT.App.Server.Pages.Airports
{
    public partial class AirportsList : ComponentBase
    {
        private bool includedICCO;
        private List<AirportModel> airports;

        [Inject]
        public IAirportDataService AirportDataService { get; set; }
        [Inject]
        public IUserInfoService UserInfoService { get; set; }
        [CascadingParameter] public IModalService Modal { get; set; }

        public List<AirportModel> Airports
        {
            get => airports;
            set
            {
                airports = value;
                StateHasChanged();
            }
        }


        public AirportModel SelectedAirport { get; set; }

        protected AddAirportDialog AddAirportDialog { get; set; }

        protected DeleteAirportDialog DeleteAirportDialog { get; set; }

        public bool IncludedICCO
        {
            get => includedICCO;
            set
            {
                includedICCO = value;
                IncludeIcao(value);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            IncludedICCO = false;
            Airports = (await AirportDataService.GetAllAirports()).ToList();
            Airports = Airports.Where(c => !string.IsNullOrWhiteSpace(c.IATA)).ToList();
            var UserId = UserInfoService.UserId;
        }
        private void GridSelectionChanged(AirportModel airport)
        {
            SelectedAirport = airport;
        }

        protected void QuickAddAirport()
        {

        }

        private async void IncludeIcao(bool includeICCAO)
        {
            if (includeICCAO)
            {
                Airports = null;
                SelectedAirport = null;
                Airports = (await AirportDataService.GetAllAirports()).ToList();
            }
            else
            {
                if (Airports != null)
                {
                    Airports = null;
                    Airports = (await AirportDataService.GetAllAirports()).ToList();
                    Airports = Airports.Where(c => !string.IsNullOrWhiteSpace(c.IATA)).ToList();
                }
            }
        }

        private void ShowDeleteAirportModal(int airportId)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(DeleteAirportDialog.AirportId), airportId);

            Modal.Show<DeleteAirportDialog>("Delete Airport", parameters);
        }
    }
}
