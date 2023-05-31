using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<Response<CategoryWithProductsDto>> GetWithProductsByIdAsync(int id);
        IQueryable<Category> GetAllWithProducts();
    }
}
