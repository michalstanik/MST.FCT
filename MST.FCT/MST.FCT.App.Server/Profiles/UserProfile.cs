using AutoMapper;
using MST.FCT.Business.Models.User.User;

namespace MST.FCT.App.Server.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserForCreationModel, UserModel>().ReverseMap();
        }
    }
}
