using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class IndividualRepository : UserRepository<Individual>, IIndividualRepository
    {
        public IndividualRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }
        public IQueryable<Individual> GetAllWithDiseases()
        {
            return _appDbContext
                .Individuals
                .Include(i => i.Diseases)
                .AsNoTracking()
                .AsQueryable();
        }
        public async Task<Individual> GetWithDiseasesByIdAsync(int id)
        {
            return await _appDbContext
                .Individuals
                .Include(i => i.Diseases)
                .SingleOrDefaultAsync(i => i.Id == id);
        }
    }
}
