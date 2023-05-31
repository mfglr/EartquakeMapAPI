using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class DiseaseRepository : Repository<Disease>,IDiseaseRepository
    {
        public DiseaseRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public IQueryable<Disease> GetAllWithIndividuals()
        {
            return _appDbContext
                .Diseases
                .Include(d => d.Individuals)
                .AsNoTracking()
                .AsQueryable();
        }

        public IQueryable<Disease> GetAllWithProducts()
        {
            return _appDbContext
                .Diseases
                .Include(d => d.Products)
                .AsNoTracking()
                .AsQueryable();
        }

        public async Task<Disease> GetWithIndividualsByIdAsync(int id)
        {
            return await _appDbContext
                .Diseases
                .Include(d => d.Individuals)
                .SingleOrDefaultAsync(d => d.Id == id);
        }

        public async Task<Disease> GetWithProductsByIdAsync(int id)
        {
            return await _appDbContext
                .Diseases
                .Include(d => d.Products)
                .SingleOrDefaultAsync(d => d.Id == id);
        }

    }
}
