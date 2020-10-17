namespace MST.FCT.Business.Models.Geo.Base
{
    /// <summary>
    /// Base model for Country
    /// </summary>
    public abstract class CountryAbstractBase
    {
        public string Name { get; set; }
        public string OfficialName { get; set; }
        public string Alpha2Code { get; set; }
        public string Alpha3Code { get; set; }
        public long Area { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
