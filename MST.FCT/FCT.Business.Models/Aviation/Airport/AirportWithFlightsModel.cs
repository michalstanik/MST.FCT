using MST.FCT.Business.Models.Aviation.Flight;
using System.Collections.Generic;

namespace MST.FCT.Business.Models.Aviation.Airport
{
    /// <summary>
    /// Airport Model with list of all inbound and outbound flights
    /// </summary>
    public class AirportWithFlightsModel : AirportModel
    {
        /// <summary>
        /// Airport Model with list of all Arrival and Departure Flights
        /// </summary>
        public AirportWithFlightsModel()
        {
            ArrivalFlights = new List<FlightModel>();
            DepartureFlights = new List<FlightModel>();
        }

        /// <summary>
        /// List of all Arrival Flights
        /// </summary>
        public List<FlightModel> ArrivalFlights { get; set; }

        /// <summary>
        /// List of all Departure Flights
        /// </summary>
        public List<FlightModel> DepartureFlights { get; set; }
    }
}
