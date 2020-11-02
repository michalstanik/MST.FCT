using System;

namespace MST.FCT.Business.Models.User.User
{
    /// <summary>
    /// FCT statistics for a user
    /// </summary>
    public class UserStats
    {
        /// <summary>
        /// Navigation property to the user
        /// </summary>
        public UserModel UserModel { get; set; }
        /// <summary>
        /// Total number of user flights
        /// </summary>
        public int UserFlightsCount { get; set; }       
        public long FlightsDistance { get; set; }
        public long FlightsTime { get; set; }
        public TimeSpan FlightTimeSpan { get; set; }
        public int AirportsCount { get; set; }
        public int AirportsCountryCount { get; set; }
    }
}
