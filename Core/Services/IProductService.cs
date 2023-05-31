using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<Response<ProductWithComponentsDto>> GetWithComponentsByIdAsync(int id);
        Task<Response<ProductWithCategoriesDto>> GetWithCategoriesByIdAsync(int id);
        Task<Response<ProductWithBusinessesDto>> GetWithBusinessesByIdAsync(int id);
        Task<Response<ProductWithDiseasesDto>> GetWithDiseasesByIdAsync(int id);

        IQueryable<Product> GetAllWithComponents();
        IQueryable<Product> GetAllWithCategories();
        IQueryable<Product> GetAllWithBusinesses();
        IQueryable<Product> GetAllWithDiseases();
    }
}
