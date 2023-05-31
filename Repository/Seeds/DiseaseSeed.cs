using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Seeds
{
    public class DiseaseSeed : IEntityTypeConfiguration<Disease>
    {
        public void Configure(EntityTypeBuilder<Disease> builder)
        {
            builder.
                HasData(
                    new Disease
                    {
                        Id = 1,
                        CreateTime = DateTime.Now,
                        Name = "Histamin İntoleransı",
                    }
                );
        }
    }
}
