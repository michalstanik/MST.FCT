using FCT.Data.Domain.User;
using FCT.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace FCT.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly FCTContext _context;

        public UserRepository(FCTContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async  Task<TUser> AddUserAsync(TUser user)
        {
            var addedEntity = _context.TUser.Add(user);
            await _context.SaveChangesAsync();
            return addedEntity.Entity;
        }

        public async Task<TUser> GetUserByIdAsync(string userId)
        {
            return await _context.TUser.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }
    }
}
