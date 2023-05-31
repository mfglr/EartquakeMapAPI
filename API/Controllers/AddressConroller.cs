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
    public class AddressConroller :ControllerBase
    {

        private IAddressService _service;
        private IMapper _mapper;

        public AddressConroller(IAddressService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        

        [HttpGet("{id}")]
        public async Task<Response<AddressDto>> GetByIdAsync(int id)
        {
            return  new Response<AddressDto>(
                _mapper.Map<AddressDto>(
                    await _service.GetByIdAsync(id)
                    )
                );
        }

        [HttpGet]
        public async Task<Response<List<AddressDto>>> GetAllAsync()
        {
            return new Response<List<AddressDto>>(
                _mapper.Map<List<AddressDto>>(
                    await _service.GetAll().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]/{placeId}")]
        public async Task<Response<AddressDto>> GetByPlaceIdAsync(string placeId)
        {
            return await _service.GetByPlaceIdAsync(placeId);
        }


        [HttpPost]
        public async Task<Response<AddressDto>> Save(AddressDto address)
        {
            return new Response<AddressDto>(
                _mapper.Map<AddressDto>(
                    await _service.AddAsync(
                        _mapper.Map<Address>(
                            address
                            )
                        )
                    )
                );
        }

        [HttpPut]
        public async Task Update(AddressDto address)
        {
            await _service.UpdateAsync(_mapper.Map<Address>(address));
        }

        [HttpDelete]
        public async Task Remove(AddressDto address)
        {
            await _service.RemoveAsync(_mapper.Map<Address>(address));
        }

    }
}
