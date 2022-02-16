using Furever.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Furever.Entities.Configurations
{
    public class AnimalConfiguration : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.HasData
            (
                new Animal
                {
                    Id = 1,
                    Name = "Skippy",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 2,
                    Name = "Felix",
                    CategoryId = 2,
                    RefugeId = 2,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(),
                    CreatedDate = new DateTime(),
                },
                 new Animal
                 {
                     Id = 3,
                     Name = "Garfield",
                     CategoryId = 3,
                     RefugeId = 2,
                     IsAvailable = true,
                     DateOfBirth = new DateTime(),
                     CreatedDate = new DateTime(),
                 },
                 new Animal
                 {
                     Id = 4,
                     Name = "Shadow",
                     CategoryId = 4,
                     RefugeId = 1,
                     IsAvailable = true,
                     DateOfBirth = new DateTime(),
                     CreatedDate = new DateTime(),
                 }
            ); ;
        }
    }
}
