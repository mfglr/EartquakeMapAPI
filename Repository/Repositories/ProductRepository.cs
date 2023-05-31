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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public IQueryable<Product> GetAllWithBusinesses()
        {
            return _appDbContext
                .Products
                .Include(p => p.Businesses)
                .AsNoTracking()
                .AsQueryable();
        }

        public IQueryable<Product> GetAllWithCategories()
        {
            return _appDbContext
                .Products
                .Include(p => p.Categories)
                .AsNoTracking()
                .AsQueryable();
        }

        public IQueryable<Product> GetAllWithComponents()
        {
            return _appDbContext
                .Products
                .Include(p => p.Components)
                .AsNoTracking()
                .AsQueryable();
        }

        public IQueryable<Product> GetAllWithDiseases()
        {
            return _appDbContext
                .Products
                .Include(p => p.Diseases)
                .AsNoTracking()
                .AsQueryable();
        }

        

        public async Task<Product> GetWithBusinessesByIdAsync(int id)
        {
            return await _appDbContext
                .Products
                .Include(p => p.Businesses)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Product> GetWithCategoriesByIdAsync(int id)
        {
            return await _appDbContext
                .Products
                .Include(p => p.Categories)
                .SingleOrDefaultAsync(p => p.Id == id);
        }


        public async Task<Product> GetWithComponentsByIdAsync(int id)
        {
            return await _appDbContext
                .Products
                .Include(p => p.Components)
                .SingleOrDefaultAsync(p => p.Id == id);

        }

        public async Task<Product> GetWithDiseasesByIdAsync(int id)
        {
            return await _appDbContext
                .Products
                .Include(p => p.Diseases)
                .SingleOrDefaultAsync(p => p.Id == id);
        }

        
    }
}
