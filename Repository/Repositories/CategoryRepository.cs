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
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public IQueryable<Category> GetAllWithProducts()
        {
            return _appDbContext.Categories.Include(c => c.Products).AsNoTracking().AsQueryable();
        }

        public Task<Category> GetWithProductsByIdAsync(int id)
        {
            return _appDbContext.Categories.Include(c => c.Products).SingleOrDefaultAsync(c => c.Id == id);
        }
    }
}
