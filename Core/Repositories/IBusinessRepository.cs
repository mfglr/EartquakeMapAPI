using Core.Models;

namespace Core.Repositories
{
    public interface IBusinessRepository : IUserRepository<Business>
    {
        Task<Business> GetWithProductsByIdAsync(int id);
        IQueryable<Business> GetAllWithProducts();
        Task<Business> GetWithAddressByIdAsync(int id);
        IQueryable<Business> GetAllWithAddress();


    }
}
