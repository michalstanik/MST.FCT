using MST.FCT.Business.Models.Aviation.Base;

namespace MST.FCT.Business.Models.Aviation.Flight
{
    /// <summary>
    /// Main Flight Model with Id
    /// </summary>
    public class FlightModel : FlightAbstractBase
    {
        /// <summary>
        /// Id of Flight
        /// </summary>
        public int Id { get; set; }
    }
}
