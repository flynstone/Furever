﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Furever.Identity.Models.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = "c5373a5f-4e1c-448d-af9c-1e150930a7ec",
            },
            new IdentityRole
            {
                Name = "Guest",
                NormalizedName = "GUEST",
                Id = "e6027a9a-8321-403d-93a4-29b8d37e0665"
            });
        }
    }
}