using AutoMapper;
using MST.FCT.Business.Models.Aviation.Airport;
using FCT.Data.Domain.Aviation;

namespace MST.FCT.API.FCTApi.Profiles
{
    /// <summary>
    /// AutoMapper for Aviation
    /// </summary>
    public class AviationProfile : Profile
    {
        /// <summary>
        /// AutoMapper for Aviation - Constructor
        /// </summary>
        public AviationProfile()
        {
            CreateMap<Airport, AirportModel>();
            CreateMap<Airport, AirportForCreationModel>().ReverseMap();
        }        
    }
}
