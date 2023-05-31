using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class BusinessService : UserService<Business>, IBusinessService
    {
        private readonly IBusinessRepository _businessRepository;
        private readonly IMapper _mapper;
        public BusinessService(
                IRepository<Business> repository,
                IUnitOfWork unitOfWork,
                IUserRepository<Business> userRepository,
                IBusinessRepository businessRepository,
                IMapper mapper
            ) : base(repository, unitOfWork, userRepository)
        {
            _businessRepository = businessRepository;
            _mapper = mapper;
        }

        public IQueryable<Business> GetAllWithAddress()
        {
            return _businessRepository.GetAllWithAddress();
        }

        public IQueryable<Business> GetAllWithProducts()
        {
            return _businessRepository.GetAllWithProducts();
        }

        public async Task<Response<BusinessWithAddressDto>> GetWithAddressByIdAsync(int id)
        {
            return new Response<BusinessWithAddressDto>
                (
                    _mapper.Map<BusinessWithAddressDto>(
                        await _businessRepository.GetWithAddressByIdAsync(id)
                        )
                );
        }

        public async Task<Response<BusinessWithProductsDto>> GetWithProductsByIdAsync(int id)
        {
            return new Response<BusinessWithProductsDto>(
                _mapper.Map<BusinessWithProductsDto>(
                    await _businessRepository.GetWithProductsByIdAsync(id)
                    )
                );
        }
    }
}
