using FCT.Data.Domain.Flights;

namespace FCT.Data.Domain.User
{
    public class UserFlight
    {
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public string TUserId { get; set; }
        public TUser TUser { get; set; }
    }
}