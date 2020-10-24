using System.ComponentModel.DataAnnotations;

namespace FCT.Business.Models.Aviation.Base
{
    /// <summary>
    /// Airport base fields
    /// </summary>
    public abstract class AirportAbstractBase
    {
        /// <summary>
        /// Name of the Airport
        /// </summary>
        [Required]
        public string Name { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string IATA { get; set; }
        public string ICAO { get; set; }
    }
}
