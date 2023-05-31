using Core.DTOs;
using Core.Models;

namespace Core.Services
{
    public interface IIndividualService : IUserService<Individual>
    {
        Task<Response<IndividualWithDiseasesDto>> GetWithDiseasesByIdAsync(int id);
        IQueryable<Individual> GetAllWithDiseases();
    }
}
