using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface IBusinessService : IUserService<Business>
    {
        Task<Response<BusinessWithProductsDto>> GetWithProductsByIdAsync(int id);
        IQueryable<Business> GetAllWithProducts();
        Task<Response<BusinessWithAddressDto>> GetWithAddressByIdAsync(int id);
        IQueryable<Business> GetAllWithAddress();
    }
}
