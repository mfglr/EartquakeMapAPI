using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.
                HasData(
                    new Category
                    {
                        Id = 1,
                        CreateTime = DateTime.Now,
                        Name = "Kabuklu Kuruyemiş",
                    }
                );
        }
    }
}
