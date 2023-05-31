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
    public class AddressRepository : Repository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext appDbContext) : base(appDbContext)
        {
        }

        public IQueryable<Address> GetAllWithBusiness()
        {
            return _appDbContext
                .Addresses
                .Include(a => a.Business)
                .AsNoTracking()
                .AsQueryable();
        }

        public async Task<Address> GetByPlaceIdAsync(string placeId)
        {
            return await _appDbContext.Addresses.SingleOrDefaultAsync(a => a.PlaceId == placeId);
        }

        public async Task<Address> GetWithBusinessByIdAsync(int id)
        {
            return await _appDbContext
                .Addresses
                .Include(a => a.Business)
                .SingleOrDefaultAsync(a => a.Id == id);
        }
    }
}
