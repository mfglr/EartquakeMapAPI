using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface IAddressService : IService<Address>
    {
        Task<Response<AddressDto>> GetByPlaceIdAsync(string placeId);
        Task<Response<AddressWithBusinessDto>> GetWithBusinessByIdAsync(int id);
        IQueryable<Address> GetAllWithBusiness();
    }
}
