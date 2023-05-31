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
    public class DiseaseController
    {
        private IDiseaseService _service;
        private IMapper _mapper;

        public DiseaseController(IDiseaseService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }


        [HttpGet("{id}")]
        public async Task<Response<DiseaseDto>> GetByIdAsync(int id)
        {
            return new Response<DiseaseDto>(
                _mapper.Map<DiseaseDto>(
                    await _service.GetByIdAsync(id)
                    )
                );
        }

        [HttpGet]
        public async Task<Response<List<DiseaseDto>>> GetAllAsync()
        {
            return new Response<List<DiseaseDto>>(
                _mapper.Map<List<DiseaseDto>>(
                    await _service.GetAll().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<DiseaseWithIndividualDto>>> GetAllWithIndividuals()
        {
            return new Response<List<DiseaseWithIndividualDto>>(
                _mapper.Map<List<DiseaseWithIndividualDto>>(
                    await _service.GetAllWithIndividuals().ToListAsync()
                    )
                );
        }
        [HttpGet("[action]")]
        public async Task<Response<List<DiseaseWithProductsDto>>> GetAllWithProducts()
        {
            return new Response<List<DiseaseWithProductsDto>>(
                _mapper.Map<List<DiseaseWithProductsDto>>(
                    await _service.GetAllWithProducts().ToListAsync()
                    )
                );
        }
        [HttpGet("[action]/{id}")]
        public async Task<Response<DiseaseWithIndividualDto>> GetWithIndividualsByIdAsync(int id)
        {
            return await _service.GetWithIndividualsByIdAsync(id);
        }
        [HttpGet("[action]/{id}")]
        public async Task<Response<DiseaseWithProductsDto>> GetWithProductsByIdAsync(int id)
        {
            return await _service.GetWithProductsByIdAsync(id);
        }


        [HttpPost]
        public async Task<Response<DiseaseDto>> Save(DiseaseDto disease)
        {
            return new Response<DiseaseDto>(
                _mapper.Map<DiseaseDto>(
                    await _service.AddAsync(
                        _mapper.Map<Disease>(
                            disease
                            )
                        )
                    )
                );
        }

        [HttpPut]
        public async Task Update(DiseaseDto disease)
        {
            await _service.UpdateAsync(_mapper.Map<Disease>(disease));
        }

        [HttpDelete]
        public async Task Remove(Disease disease)
        {
            await _service.RemoveAsync(_mapper.Map<Disease>(disease));
        }

    }
}
