using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface IDiseaseService : IService<Disease>
    {
        Task<Response<DiseaseWithIndividualDto>> GetWithIndividualsByIdAsync(int id);
        IQueryable<Disease> GetAllWithIndividuals();

        Task<Response<DiseaseWithProductsDto>> GetWithProductsByIdAsync(int id);
        IQueryable<Disease> GetAllWithProducts();
    }
}
