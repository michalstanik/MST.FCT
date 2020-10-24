using System;
using System.Collections.Generic;

namespace FCT.Data.Domain.User
{
    public class TUser
    {
        public TUser()
        {
            UserFlights = new List<UserFlight>();
        }
        public string Id { get; set; }

        public string UserName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime LastLoginTime { get; set; }

        public List<UserFlight> UserFlights { get; set; }
    }
}
