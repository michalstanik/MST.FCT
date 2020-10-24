using FCT.Data.Domain.User;
using System.Threading.Tasks;

namespace FCT.Data.IRepositories
{
    public interface IUserRepository
    {
        Task<TUser> GetUserByIdAsync(string userId);
        Task<TUser> AddUserAsync(TUser user);
    }
}
