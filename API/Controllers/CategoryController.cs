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
    public class CategoryController :ControllerBase
    {
        private ICategoryService _service;
        private IMapper _mapper;

        public CategoryController(ICategoryService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;

        }

        [HttpGet("{id}")]
        public async Task<Response<CategoryDto>> GetByIdAsync(int id)
        {
            return new Response<CategoryDto>(
                _mapper.Map<CategoryDto>(
                    await _service.GetByIdAsync(id)
                    )
                );
        }

        [HttpGet]
        public async Task<Response<List<CategoryDto>>> GetAllAsync()
        {
            return new Response<List<CategoryDto>>(
                _mapper.Map<List<CategoryDto>>(
                    await _service.GetAll().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]")]
        public async Task<Response<List<CategoryWithProductsDto>>> GetAllWithProducts()
        {
            return new Response<List<CategoryWithProductsDto>>(
                _mapper.Map<List<CategoryWithProductsDto>>(
                    await _service.GetAllWithProducts().ToListAsync()
                    )
                );
        }

        [HttpGet("[action]/{id}")]
        public async Task<Response<CategoryWithProductsDto>> GetWithProductsByIdAsync(int id)
        {
            return await _service.GetWithProductsByIdAsync(id);
        }


        [HttpPost]
        public async Task<Response<CategoryDto>> Save(CategoryDto category)
        {
            return new Response<CategoryDto>(
                _mapper.Map<CategoryDto>(
                    await _service.AddAsync(
                        _mapper.Map<Category>(
                            category
                            )
                        )
                    )
                );

        }

        [HttpPut]
        public async Task Update(CategoryDto category)
        {
            await _service.UpdateAsync(_mapper.Map<Category>(category));
        }

        [HttpDelete]
        public async Task Remove(CategoryDto category)
        {
            await _service.RemoveAsync(_mapper.Map<Category>(category));
        }

    }
}
