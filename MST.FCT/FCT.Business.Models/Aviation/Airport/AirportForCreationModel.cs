using FCT.Business.Models.Aviation.Base;
using MST.FCT.Business.Models.Geo.Country;
using System.ComponentModel.DataAnnotations;

namespace MST.FCT.Business.Models.Aviation.Airport
{
    /// <summary>
    /// Airport Base Model used for creation
    /// </summary>
    public class AirportForCreationModel : AirportAbstractBase
    {
        /// <summary>
        /// Name of the Airport - Limited to 50 length
        /// </summary>
        [Required]
        [MaxLength(50)]
        public new string Name { get; set; }
        /// <summary>
        /// ICAO code - 4 letters code
        /// </summary>
        [Required]
        [MaxLength(4)]
        public new string ICAO { get; set; }
        /// <summary>
        /// Id for a Cuntry entity
        /// </summary>
        public CountryModel Country { get; set; }

    }
}
