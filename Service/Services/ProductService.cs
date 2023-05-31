using AutoMapper;
using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Core.Services;
using Core.UnitOfWorks;

namespace Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private IProductRepository _productRepository;
        private IMapper _mapper;
        public ProductService(
                IRepository<Product> repository,
                IUnitOfWork unitOfWork,
                IProductRepository productRepository,
                IMapper mapper
            ) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public IQueryable<Product> GetAllWithBusinesses()
        {
            return _productRepository.GetAllWithBusinesses();
        }

        public IQueryable<Product> GetAllWithCategories()
        {
            return _productRepository.GetAllWithCategories();
        }

        public IQueryable<Product> GetAllWithComponents()
        {
            return _productRepository.GetAllWithComponents();
        }

        public IQueryable<Product> GetAllWithDiseases()
        {
            return _productRepository.GetAllWithDiseases();
        }

        public async Task<Response<ProductWithBusinessesDto>> GetWithBusinessesByIdAsync(int id)
        {
            return new Response<ProductWithBusinessesDto>(
                _mapper.Map<ProductWithBusinessesDto>(
                    await _productRepository.GetWithBusinessesByIdAsync(id)
                    )
                );
        }

        public async Task<Response<ProductWithCategoriesDto>> GetWithCategoriesByIdAsync(int id)
        {
            return new Response<ProductWithCategoriesDto>(
                _mapper.Map<ProductWithCategoriesDto>(
                    await _productRepository.GetWithCategoriesByIdAsync(id)
                    )
                );
        }

        public async Task<Response<ProductWithComponentsDto>> GetWithComponentsByIdAsync(int id)
        {
            return new Response<ProductWithComponentsDto>(
                _mapper.Map< ProductWithComponentsDto >(
                    await _productRepository.GetWithComponentsByIdAsync(id)
                    )
                );
        }

        public async Task<Response<ProductWithDiseasesDto>> GetWithDiseasesByIdAsync(int id)
        {
            return new Response<ProductWithDiseasesDto>(
                _mapper.Map<ProductWithDiseasesDto>(
                    await _productRepository.GetWithDiseasesByIdAsync(id)
                    )
                );
        }
    }
}
