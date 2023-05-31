using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class AddressSeed : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder
                .HasData(
                    new Address
                    {
                        Id = 1,
                        CreateTime = DateTime.Now,
                        PlaceId = "ChIJyVyJIcM-yhQRmVL98P6vD-4"
                    },
                    new Address
                    {
                        Id = 2,
                        CreateTime = DateTime.Now,
                        PlaceId = "ChIJ1SkRIsM-yhQRDQUFyzsB0NU"
                    },
                    new Address
                    {
                        Id = 3,
                        CreateTime = DateTime.Now,
                        PlaceId = "ChIJG4i1GMM-yhQRh26JXS9AXwY"
                    }
                );
        }
    }
}
