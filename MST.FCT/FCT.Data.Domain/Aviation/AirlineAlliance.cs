using System.Collections.Generic;

namespace FCT.Data.Domain.Aviation
{
    public class AirlineAlliance
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Airline> Airlines { get; set; }
    }
}