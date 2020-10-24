using MST.FCT.Business.Models.User.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MST.FCT.Business.Services
{
    public interface IUserDataService
    {
        Task<UserForCreationModel> AddUser(UserForCreationModel user);
        Task<UserModel> GetUserById(string id);
    }
}
