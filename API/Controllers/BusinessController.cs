using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessController : ControllerBase
    {

        private IBusinessService _service;
        private IMapper _mapper;
        public BusinessController(IBusinessService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<Response<BusinessDto>> GetByIdAsync(int id)
        {
            return new Response<BusinessDto>(
                _mapper.Map<BusinessDto>(
                    await _service.GetByIdAsync(id)
                    )
                );
        }

        [HttpGet]
        public async Task<Response<List<BusinessDto>>> GetAllAsync()
        {
            return new Response<List<BusinessDto>>(
                _mapper.Map<List<BusinessDto>>(
                    await _service.GetAll().ToListAsync()
                    )
                );
        }


        [HttpGet("[action]/{email}")]
        public async Task<Response<BusinessDto>> GetByEmailAsync(string email)
        {
            return new Response<BusinessDto>(
                _mapper.Map<BusinessDto>(
                    await _service.GetByEmailAsync(email)
                    )
                );
        }

        [HttpGet("[action]/{username}")]
        public async Task<Response<BusinessDto>> GetByUsernameAsync(string username)
        {
            return new Response<BusinessDto>(
                _mapper.Map<BusinessDto>(
                    await _service.GetByUsernameAsync(username)
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<BusinessWithAddressDto>>> GetAllWithAddress()
        {
            return new Response<List<BusinessWithAddressDto>>(
                _mapper.Map<List<BusinessWithAddressDto>>(
                    await _service.GetAllWithAddress().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<BusinessWithProductsDto>>> GetAllWithProducts()
        {
            return new Response<List<BusinessWithProductsDto>>(
                _mapper.Map<List<BusinessWithProductsDto>>(
                    await _service.GetAllWithProducts().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]/{id}")]
        public async Task<Response<BusinessWithAddressDto>> GetWithAddressByIdAsync(int id)
        {
            return await _service.GetWithAddressByIdAsync(id);
        }

        [HttpGet("[action]/{id}")]
        public async Task<Response<BusinessWithProductsDto>> GetWithProductsByIdAsync(int id)
        {
            return await _service.GetWithProductsByIdAsync(id);
        }

        [HttpPost]
        public async Task<Response<BusinessDto>> Save(BusinessDto business)
        {
            return new Response<BusinessDto>(
                _mapper.Map<BusinessDto>(
                    await _service.AddAsync(
                        _mapper.Map<Business>(business)
                        )
                    )
                );
        }

        [HttpPut]
        public async Task Update(BusinessDto business)
        {
            await _service.UpdateAsync(_mapper.Map<Business>(business));
        }

        [HttpDelete]
        public async Task Remove(BusinessDto business)
        {
            await _service.RemoveAsync(_mapper.Map<Business>(business));
        }
    }
}
