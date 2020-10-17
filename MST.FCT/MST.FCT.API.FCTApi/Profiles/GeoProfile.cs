using AutoMapper;
using FCT.Data.Domain.Geo;
using MST.FCT.Business.Models.Geo.Country;

namespace MST.FCT.API.FCTApi.Profiles
{
    public class GeoProfile: Profile
    {
        public GeoProfile()
        {
            CreateMap<Country, CountryModel>().ReverseMap();
        }        
    }
}
