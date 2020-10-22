using System;

namespace MST.FCT.Business.Models.Aviation.Base
{
    public abstract class FlightAbstractBase
    {
        public string FlightNumber { get; set; }

        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivialDate { get; set; }

        public long? Distance { get; set; }
        public long? FlightTime { get; set; }
    }
}
