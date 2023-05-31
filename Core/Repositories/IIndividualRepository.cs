using Core.Models;

namespace Core.Repositories
{
    public interface IIndividualRepository : IUserRepository<Individual>
    {
        Task<Individual> GetWithDiseasesByIdAsync(int id);
        IQueryable<Individual> GetAllWithDiseases();
    }
}
