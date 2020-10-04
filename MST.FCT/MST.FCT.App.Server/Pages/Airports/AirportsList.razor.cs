﻿using MST.FCT.Business.Models.Aviation.Airport;
using FCT.Business.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;

namespace MST.FCT.App.Server.Pages.Airports
{
    public partial class AirportsList : ComponentBase
    {
        private bool includedICCO;

        [Inject]
        public IAirportDataService AirportDataService { get; set; }

        public List<AirportModel> Airports { get; set; }


        public AirportModel SelectedAirport { get; set; }

        public bool IncludedICCO 
        {
            get => includedICCO;
            set
            {
                includedICCO = value;
                //IncludeIcao(value);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            IncludedICCO = false;
            Airports = (await AirportDataService.GetAllAirports()).ToList();
            Airports = Airports.Where(c => !string.IsNullOrWhiteSpace(c.IATA)).ToList();
        }
        private void GridSelectionChanged(AirportModel airport)
        {
            SelectedAirport = airport;
        }

        private async void IncludeIcao(bool includeICCAO)
        {
            if (includeICCAO)
            {
                Airports = null;
                Airports = (await AirportDataService.GetAllAirports()).ToList();
            }
            else
            {
                Airports = (await AirportDataService.GetAllAirports()).ToList();
                Airports = Airports.Where(c => !string.IsNullOrWhiteSpace(c.IATA)).ToList();
            }
        }
    }
}
