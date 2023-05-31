using Core.Models;

namespace Core.Services
{
    public interface IUserService<T> : IService<T> where T : User
    {
        public Task<T> GetByUsernameAsync(string username);
        public Task<T> GetByEmailAsync(string email);
    }
}
