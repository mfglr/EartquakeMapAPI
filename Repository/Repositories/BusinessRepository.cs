using Core.DTOs;
using Core.Models;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Repository.Repositories
{
    public class BusinessRepository : UserRepository<Business>, IBusinessRepository
    {

        public BusinessRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public IQueryable<Business> GetAllWithAddress()
        {
            return _appDbContext.Businesses.Include(b => b.Address).AsNoTracking().AsQueryable();
        }

        public IQueryable<Business> GetAllWithProducts()
        {
            return _appDbContext.Businesses.Include(b => b.Products).AsNoTracking().AsQueryable();
        }

        public async Task<Business> GetWithAddressByIdAsync(int id)
        {
            return await _appDbContext.Businesses.Include(b => b.Address).SingleOrDefaultAsync(b => b.Id == id);
        }

        public async Task<Business> GetWithProductsByIdAsync(int id)
        {
            return await _appDbContext.Businesses.Include(b => b.Products).SingleOrDefaultAsync(b => b.Id == id);
        }
    }
}
