using System.Collections.Generic;

namespace FCT.Data.Domain.Aviation
{
    public class AircraftFactory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int? AircraftFactoryCountryId { get; set; }
        //TODO: Enable countries
        //public Country AircraftFactoryCountry { get; set; }

        public List<AircraftModel> AircraftModels { get; set; }
    }
}