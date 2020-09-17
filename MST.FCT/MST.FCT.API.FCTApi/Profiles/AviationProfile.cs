using AutoMapper;
using FCT.Business.Models.Aviation.Airport;
using FCT.Data.Domain.Aviation;

namespace MST.FCT.API.FCTApi.Profiles
{
    public class AviationProfile : Profile
    {
        public AviationProfile()
        {
            CreateMap<Airport, AirportModel>();
        }        
    }
}
