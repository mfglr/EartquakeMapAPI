using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class BusinessSeed : IEntityTypeConfiguration<Business>
    {
        public void Configure(EntityTypeBuilder<Business> builder)
        {
            builder
                .HasData(
                    new Business
                    {
                        Id = 1,
                        CreateTime = DateTime.Now,
                        Username = "usernameBusiness1",
                        Password = "123456",
                        Email = "emailBusiness1",
                        Name = "name1"
                    },
                    new Business
                    {
                        Id = 2,
                        CreateTime = DateTime.Now,
                        Username = "usernameBusiness2",
                        Password = "123456",
                        Email = "emailBusiness2",
                        Name = "name2"
                    },
                    new Business
                    {
                        Id = 3,
                        CreateTime = DateTime.Now,
                        Username = "usernameBusiness3",
                        Password = "123456",
                        Email = "emailBusiness3",
                        Name = "name3"
                    }
                );
        }
    }
}
