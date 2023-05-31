using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasData(
                    new Product
                    {
                        Id = 1,
                        CreateTime = DateTime.Now,
                        Name = "fındık",
                    },
                    new Product
                    {
                        Id = 2,
                        CreateTime = DateTime.Now,
                        Name = "badem",
                    },
                    new Product
                    {
                        Id = 3,
                        CreateTime = DateTime.Now,
                        Name = "ceviz",
                    },
                    new Product
                    {
                        Id = 4,
                        CreateTime = DateTime.Now,
                        Name = "fıstık",
                    },
                    new Product
                    {
                        Id = 5,
                        CreateTime = DateTime.Now,
                        Name = "kaju",
                    }
                );
        }
    }
}
