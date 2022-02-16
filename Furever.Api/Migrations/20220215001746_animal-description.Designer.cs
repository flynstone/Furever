﻿// <auto-generated />
using System;
using Furever.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Furever.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220215001746_animal-description")]
    partial class animaldescription
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.14");

            modelBuilder.Entity("Furever.Entities.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("RefugeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RefugeId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvailable = true,
                            Name = "Skippy",
                            RefugeId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvailable = true,
                            Name = "Felix",
                            RefugeId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvailable = true,
                            Name = "Garfield",
                            RefugeId = 2
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DateOfBirth = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            IsAvailable = true,
                            Name = "Shadow",
                            RefugeId = 1
                        });
                });

            modelBuilder.Entity("Furever.Entities.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Species")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Species = "Dogs"
                        },
                        new
                        {
                            Id = 2,
                            Species = "Cats"
                        },
                        new
                        {
                            Id = 3,
                            Species = "Birds"
                        },
                        new
                        {
                            Id = 4,
                            Species = "Reptiles"
                        });
                });

            modelBuilder.Entity("Furever.Entities.Models.Favorite", b =>
                {
                    b.Property<int>("AnimalId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AnimalId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("Favorites");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            UserId = 2
                        },
                        new
                        {
                            AnimalId = 2,
                            UserId = 2
                        },
                        new
                        {
                            AnimalId = 2,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Furever.Entities.Models.Refuge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Refuges");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "123 Fake Avenue",
                            City = "Ottawa",
                            Email = "owner@test.com",
                            FirstName = "Owner",
                            LastName = "Test",
                            Username = "Testing"
                        },
                        new
                        {
                            Id = 2,
                            Address = "123 Fake Street",
                            City = "Montreal",
                            Email = "test@owner.com",
                            FirstName = "Test",
                            LastName = "Owner",
                            Username = "Guest_01"
                        });
                });

            modelBuilder.Entity("Furever.Entities.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Test",
                            LastName = "User"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "User",
                            LastName = "Test"
                        });
                });

            modelBuilder.Entity("Furever.Entities.Models.Animal", b =>
                {
                    b.HasOne("Furever.Entities.Models.Category", "Category")
                        .WithMany("Animals")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Furever.Entities.Models.Refuge", "Refuge")
                        .WithMany("Animals")
                        .HasForeignKey("RefugeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Refuge");
                });

            modelBuilder.Entity("Furever.Entities.Models.Favorite", b =>
                {
                    b.HasOne("Furever.Entities.Models.Animal", "Animal")
                        .WithMany("Favorites")
                        .HasForeignKey("AnimalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Furever.Entities.Models.User", "User")
                        .WithMany("Favorites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Animal");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Furever.Entities.Models.Animal", b =>
                {
                    b.Navigation("Favorites");
                });

            modelBuilder.Entity("Furever.Entities.Models.Category", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Furever.Entities.Models.Refuge", b =>
                {
                    b.Navigation("Animals");
                });

            modelBuilder.Entity("Furever.Entities.Models.User", b =>
                {
                    b.Navigation("Favorites");
                });
#pragma warning restore 612, 618
        }
    }
}
