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
                    Name = "Daisy",
                    Description = "2 year old, Female, Cavalier King Charles Spaniel",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2019, 10, 10),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 2,
                    Name = "Duke",
                    Description = "4 year old, Male, German Sheppard",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2017, 08, 12),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 3,
                    Name = "Gus",
                    Description = "3 year old, Male, Boxer",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2018, 09, 09),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 4,
                    Name = "Jasper",
                    Description = "4 month old, Male, Maltese",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 11, 12),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 5,
                    Name = "Kobe",
                    Description = "3 year old, Male, Corgi",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2018, 06, 12),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 6,
                    Name = "Luna",
                    Description = "2 year old, Female, Siberian Husky",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 7,
                    Name = "Milo",
                    Description = "4 year old, Male, Pug",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2017, 12, 01),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 8,
                    Name = "Molly and Toby",
                    Description = "6 month old, Brother and Sister, Labrador Retrievers",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 08, 10),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 9,
                    Name = "Rocky",
                    Description = "6 month old, Male, German Sheppard",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 08, 01),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 10,
                    Name = "Zoe",
                    Description = "5 month old, Female, Yorkshire Terrier",
                    CategoryId = 1,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 09, 07),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 11,
                    Name = "Abby",
                    Description = "7 year old, Female, Gray & White Maine Coon",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2015, 01, 10),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 12,
                    Name = "Binx",
                    Description = "5 month old, Male, Tri-Color Short Hair, Kitten",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 09, 30),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 13,
                    Name = "Jade",
                    Description = "6 year old, Female, Short Hair",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2016, 07, 07),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 14,
                    Name = "Jax",
                    Description = "5 year old, Male, Gray Short Hair",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2017, 05, 20),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 15,
                    Name = "Lucy",
                    Description = "4 month old, Female, White Kitten",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 10, 30),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 16,
                    Name = "Lulu",
                    Description = "3 month old, Female, Orange Tabby",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 11, 10),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 17,
                    Name = "Ollie",
                    Description = "7 month old, Male, Gray Kitten",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 07, 15),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 18,
                    Name = "Oreo",
                    Description = "4 month old, Male, Black and White Kitten",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 10, 15),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 19,
                    Name = "Rosie",
                    Description = "3 month old, Female, Gray and White Kitten",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2021, 10, 14),
                    CreatedDate = new DateTime(),
                },
                new Animal
                {
                    Id = 20,
                    Name = "Simba",
                    Description = "8 year old, Male, Orange and Gray Short Hair",
                    CategoryId = 2,
                    RefugeId = 1,
                    IsAvailable = true,
                    DateOfBirth = new DateTime(2014, 01, 15),
                    CreatedDate = new DateTime(),
                }
            ); ;
        }
    }
}
