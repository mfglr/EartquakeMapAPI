using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(
                IRepository<Category> repository,
                IUnitOfWork unitOfWork,
                ICategoryRepository categoryRepository,
                IMapper mapper
            ) : base(repository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IQueryable<Category> GetAllWithProducts()
        {
            return _categoryRepository.GetAllWithProducts();
        }

        public async Task<Response<CategoryWithProductsDto>> GetWithProductsByIdAsync(int id)
        {
            return new Response<CategoryWithProductsDto>(
                _mapper.Map<CategoryWithProductsDto>(
                    await _categoryRepository.GetWithProductsByIdAsync(id)
                    )
                );
        }
    }
}
