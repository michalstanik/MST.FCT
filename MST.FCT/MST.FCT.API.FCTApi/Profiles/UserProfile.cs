using AutoMapper;
using FCT.Data.Domain.User;
using MST.FCT.Business.Models.User.User;

namespace MST.FCT.API.FCTApi.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<TUser, UserModel>().ReverseMap();
            CreateMap<UserForCreationModel, TUser>();
        }
    }
}
