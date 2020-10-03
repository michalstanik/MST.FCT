namespace FCT.Business.Models.Aviation.Base
{
    public abstract class AirportAbstractBase
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get;set; }
        public string CountryName { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }
    }
}
