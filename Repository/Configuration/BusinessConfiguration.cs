using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class BusinessConfiguration : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder
                .HasMany(b => b.Products)
                .WithMany(p => p.Businesses);

            builder
                .HasOne(b => b.Address)
                .WithOne(a => a.Business)
                .HasForeignKey<Address>(a => a.Id);
        }
    }
}
