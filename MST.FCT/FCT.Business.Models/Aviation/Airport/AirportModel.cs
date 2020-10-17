using FCT.Business.Models.Aviation.Base;

namespace MST.FCT.Business.Models.Aviation.Airport
{
    /// <summary>
    /// Airport Base Model with Id
    /// </summary>
    public class AirportModel : AirportAbstractBase
    {
        /// <summary>
        /// The Id for a Trip
        /// </summary>
        public int Id { get; set; }
        public string CountryAlpha3Code { get; set; }
        public string CountryName { get; set; }
    }
}
