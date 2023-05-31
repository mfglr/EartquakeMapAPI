using Core.Models;

namespace Core.Repositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        Task<Address> GetByPlaceIdAsync(string placeId);
        Task<Address> GetWithBusinessByIdAsync(int id);
        IQueryable<Address> GetAllWithBusiness();
    }
}
