using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Seeds
{
    public class IndividualSeed : IEntityTypeConfiguration<Individual>
    {
        public void Configure(EntityTypeBuilder<Individual> builder)
        {
            builder
                .HasData(
                    new Individual
                    {
                        Id = 1,
                        CreateTime = DateTime.Now,
                        Username = "usernameIdivual1",
                        Password = "123456",
                        Email = "emailIndivudual1",
                        Name = "name1",
                        LastName = "lastname1",
                        Birthday = DateTime.Now
                    },
                    new Individual
                    {
                        Id = 2,
                        CreateTime = DateTime.Now,
                        Username = "usernameIdivual2",
                        Password = "123456",
                        Email = "emailIndivudual2",
                        Name = "name2",
                        LastName = "lastname2",
                        Birthday = DateTime.Now
                    },
                    new Individual
                    {
                        Id = 3,
                        CreateTime = DateTime.Now,
                        Username = "usernameIdivual3",
                        Password = "123456",
                        Email = "emailIndivudual3",
                        Name = "name3",
                        LastName = "lastname3",
                        Birthday = DateTime.Now
                    }
                );
        }
    }
}
