using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class AddressService : Service<Address>, IAddressService
    {
        private IAddressRepository _addressRepository;
        private readonly IMapper _mapper;
        public AddressService(
                IRepository<Address> repository,
                IUnitOfWork unitOfWork,
                IAddressRepository addressRepository,
                IMapper mapper
            ) : base(repository, unitOfWork)
        {
            _addressRepository = addressRepository;
            _mapper = mapper;
        }

        public IQueryable<Address> GetAllWithBusiness()
        {
            return _addressRepository.GetAllWithBusiness();
        }

        public async Task<Response<AddressDto>> GetByPlaceIdAsync(string placeId)
        {
            return new Response<AddressDto>(
                _mapper.Map<AddressDto>(
                    await _addressRepository.GetByPlaceIdAsync(placeId)
                    )
                );
        }

        public async Task<Response<AddressWithBusinessDto>> GetWithBusinessByIdAsync(int id)
        {
            return new Response<AddressWithBusinessDto>(
                _mapper.Map<AddressWithBusinessDto>(
                    await _addressRepository.GetWithBusinessByIdAsync(id)
                    )
                );
        }
    }
}
