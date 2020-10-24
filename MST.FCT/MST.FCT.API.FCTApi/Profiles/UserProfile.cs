using AutoMapper;
using FCT.Data.Domain.User;
using MST.FCT.Business.Models.User.User;

namespace MST.FCT.API.FCTApi.Profiles
{
    /// <summary>
    /// Automapper profile for User mappings
    /// </summary>
    public class UserProfile : Profile
    {
        /// <summary>
        /// Defoult constructor
        /// </summary>
        public UserProfile()
        {
            CreateMap<TUser, UserModel>().ReverseMap();
            CreateMap<UserForCreationModel, TUser>().ReverseMap();
        }
    }
}
