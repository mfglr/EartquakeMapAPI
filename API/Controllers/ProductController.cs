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
    public class ProductController
    {

        private IProductService _service;
        private IMapper _mapper;

        public ProductController(IProductService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public async Task<Response<ProductDto>> GetByIdAsync(int id)
        {
            return new Response<ProductDto>(
                _mapper.Map<ProductDto>(
                    await _service.GetByIdAsync(id)
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<ProductDto>>> GetAllAsync()
        {
            return new Response<List<ProductDto>>(
                _mapper.Map<List<ProductDto>>(
                    await _service.GetAll().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<ProductWithBusinessesDto>>> GetAllWithBusinessesAsync()
        {
            return new Response<List<ProductWithBusinessesDto>>(
                _mapper.Map<List<ProductWithBusinessesDto>>(
                    await _service.GetAllWithBusinesses().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<ProductWithCategoriesDto>>> GetAllWithCategoriesAsync()
        {
            return new Response<List<ProductWithCategoriesDto>>(
                _mapper.Map<List<ProductWithCategoriesDto>>(
                    await _service.GetAllWithCategories().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<ProductWithComponentsDto>>> GetAllWithComponentsAsync()
        {
            return new Response<List<ProductWithComponentsDto>>(
                _mapper.Map<List<ProductWithComponentsDto>>(
                    await _service.GetAllWithComponents().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<ProductWithDiseasesDto>>> GetAllWithDiseasesAsync()
        {
            return new Response<List<ProductWithDiseasesDto>>(
                _mapper.Map<List<ProductWithDiseasesDto>>(
                    await _service.GetAllWithDiseases().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]/{id}")]
        public async Task<Response<ProductWithBusinessesDto>> GetWithBusinessesByIdAsync(int id)
        {
            return await _service.GetWithBusinessesByIdAsync(id);
        }
        [HttpGet("[action]/{id}")]
        public async Task<Response<ProductWithCategoriesDto>> GetWithCategoriesByIdAsync(int id)
        {
            return await _service.GetWithCategoriesByIdAsync(id);
        }
        [HttpGet("[action]/{id}")]
        public async Task<Response<ProductWithComponentsDto>> GetWithComponentsByIdAsync(int id)
        {
            return await _service.GetWithComponentsByIdAsync(id);
        }
        [HttpGet("[action]/{id}")]
        public async Task<Response<ProductWithDiseasesDto>> GetWithDiseasesByIdAsync(int id)
        {
            return await _service.GetWithDiseasesByIdAsync(id);
        }


        [HttpPost]
        public async Task<Response<ProductDto>> Save(ProductDto product)
        {
            return new Response<ProductDto>(
                _mapper.Map<ProductDto>(
                    await _service.AddAsync(
                        _mapper.Map<Product>(
                            product
                            )
                        )
                    )
                );
        }

        [HttpPut]
        public async Task Update(ProductDto product)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(product));
        }

        [HttpDelete]
        public async Task Remove(ProductDto product)
        {
            await _service.RemoveAsync(_mapper.Map<Product>(product));
        }
    }
}
