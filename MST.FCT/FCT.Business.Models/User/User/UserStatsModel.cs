using System;

namespace MST.FCT.Business.Models.User.User
{
    /// <summary>
    /// FCT statistics for a user
    /// </summary>
    public class UserStatsModel
    {
        /// <summary>
        /// Navigation property to the user
        /// </summary>
        public UserModel UserModel { get; set; }
        /// <summary>
        /// Total number of user flights
        /// </summary>
        public int UserFlightsCount { get; set; }
        /// <summary>
        /// Total distance of Usr flights in km
        /// </summary>
        public long FlightsDistance { get; set; }
        /// <summary>
        /// Total flight time for user in hours
        /// </summary>
        public long FlightsTime { get; set; }
        /// <summary>
        /// Total flight time for user in TimeSpan
        /// Not used in current implementation
        /// </summary>
        public TimeSpan FlightTimeSpan { get; set; }
        /// <summary>
        /// Visited uniqe airport count for user
        /// </summary>
        public int AirportsCount { get; set; }
        /// <summary>
        /// Visited uniqe countries associated with airports for user
        /// </summary>
        public int AirportsCountryCount { get; set; }
        /// <summary>
        /// Uniqge Airplane model count
        /// </summary>
        public int AirplaneModelCount { get; set; }
    }
}
