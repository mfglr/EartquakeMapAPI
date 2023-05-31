using Core.Models;

namespace Core.Repositories
{
    public interface IDiseaseRepository : IRepository<Disease>
    {
        Task<Disease> GetWithIndividualsByIdAsync(int id);
        IQueryable<Disease> GetAllWithIndividuals();

        Task<Disease> GetWithProductsByIdAsync(int id);
        IQueryable<Disease> GetAllWithProducts();

    }
}
