using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class UserService<T> : Service<T>, IUserService<T> where T : User
    {

        private IUserRepository<T> _userRepository;
        public UserService(IRepository<T> repository, IUnitOfWork unitOfWork, IUserRepository<T> userRepository) : base(repository, unitOfWork)
        {
            _userRepository = userRepository;
        }

        public async Task<T> GetByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<T> GetByUsernameAsync(string username)
        {
            return await _userRepository.GetByUsernameAsync(username);
        }
    }
}
