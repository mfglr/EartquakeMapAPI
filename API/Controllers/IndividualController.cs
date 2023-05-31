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
    public class IndividualController : ControllerBase
    {
        private IIndividualService _service;
        private IMapper _mapper;
        public IndividualController(IIndividualService service,IMapper mapper) {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<Response<IndividualDto>> GetByIdAsync(int id){
            return new Response<IndividualDto>(
                    _mapper.Map<IndividualDto>(await _service.GetByIdAsync(id)
                    )
                );
        }

        [HttpGet]
        public async Task<Response<List<IndividualDto>>> GetAllAsync()
        {
            return new Response<List<IndividualDto>>(
                _mapper.Map<List<IndividualDto>>(
                    await _service.GetAll().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]/{email}")]
        public async Task<Response<IndividualDto>> GetByEmailAsync(string email)
        {
            return new Response<IndividualDto>(
                _mapper.Map<IndividualDto>(
                    await _service.GetByEmailAsync(email)
                    )
                );
        }

        [HttpGet("[action]/{username}")]
        public async Task<Response<IndividualDto>> GetByUsernameAsync(string username)
        {
            return new Response<IndividualDto>(
                _mapper.Map<IndividualDto>(
                    await _service.GetByUsernameAsync(username)
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<IndividualWithDiseasesDto>>> GetAllWithDiseases()
        {
            return new Response<List<IndividualWithDiseasesDto>>(
                _mapper.Map<List<IndividualWithDiseasesDto>>(
                    await _service.GetAllWithDiseases().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]/{id}")]
        public async Task<Response<IndividualWithDiseasesDto>> GetWithDiseasesByIdAsync(int id)
        {
            return await _service.GetWithDiseasesByIdAsync(id);
        }

        [HttpPost]
        public async Task<Response<IndividualDto>> Save(IndividualDto individual)
        {
            return new Response<IndividualDto>(
                    _mapper.Map<IndividualDto>(
                    await _service.AddAsync(
                        _mapper.Map<Individual>(
                            individual
                            )
                        )
                    )
                );
        }

        [HttpPut]
        public async Task Update(IndividualDto individual)
        {
            await _service.UpdateAsync(_mapper.Map<Individual>(individual));
        }

        [HttpDelete]
        public async Task Remove(IndividualDto individual)
        {
            await _service.RemoveAsync(_mapper.Map<Individual>(individual));
        }
    }
}
