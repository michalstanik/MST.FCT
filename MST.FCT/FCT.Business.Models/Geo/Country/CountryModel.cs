using MST.FCT.Business.Models.Geo.Base;

namespace MST.FCT.Business.Models.Geo.Country
{
    /// <summary>
    /// Country Model
    /// </summary>
    public class CountryModel : CountryAbstractBase
    {
        public int Id { get; set; }
        public string RegionName { get; set; }
    }
}
