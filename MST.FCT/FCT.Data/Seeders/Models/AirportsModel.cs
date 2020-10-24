namespace FCT.Data.Seeders.Models
{
    public class AirportsModel
    {
        public class AirportModel
        {
            public string icao { get; set; }
            public string iata { get; set; }
            public string name { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string country { get; set; }
            public int elevation { get; set; }
            public double lat { get; set; }
            public double lon { get; set; }
            public string tz { get; set; }
        }
        public class RootObject
        {
            public AirportModel AirportModel { get; set; }
        }
    }
}
