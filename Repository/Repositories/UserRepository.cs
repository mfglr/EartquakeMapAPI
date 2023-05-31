using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
namespace Repository.Repositories
{
    public class UserRepository<T> : Repository<T>, IUserRepository<T> where T : User
    {
        public UserRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public async Task<T> GetByEmailAsync(string email)
        {
            return await _dbSet.SingleOrDefaultAsync(t => t.Email == email);
        }

        public async Task<T> GetByUsernameAsync(string username)
        {
            return await _dbSet.SingleOrDefaultAsync(t => t.Username == username);
        }
    }
}
