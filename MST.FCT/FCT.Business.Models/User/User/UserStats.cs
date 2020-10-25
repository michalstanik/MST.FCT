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
        public int UserFlights { get; set; }        
    }
}
