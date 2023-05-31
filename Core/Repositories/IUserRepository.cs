using Core.Models;

namespace Core.Repositories
{
    public interface IUserRepository<T> : IRepository<T> where T : User
    {
        public Task<T> GetByUsernameAsync(string username);
        public Task<T> GetByEmailAsync(string email);
    }
}
