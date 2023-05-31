using Core.Models;

namespace Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<Product> GetWithComponentsByIdAsync(int id);
        Task<Product> GetWithCategoriesByIdAsync(int id);
        Task<Product> GetWithBusinessesByIdAsync(int id);
        Task<Product> GetWithDiseasesByIdAsync(int id);

        IQueryable<Product> GetAllWithComponents();
        IQueryable<Product> GetAllWithCategories();
        IQueryable<Product> GetAllWithBusinesses();
        IQueryable<Product> GetAllWithDiseases();
    }
}
