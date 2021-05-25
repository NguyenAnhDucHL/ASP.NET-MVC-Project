using System;
using System.Collections.Generic;
using System.Text;
using HuaweiReg.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuaweiReg.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        private const string adminId = "40DB3A70-9EE6-4CF3-997A-C6262C622A47";
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var admin = new User
            {
                Id = adminId,
                UserName = "Administrator",
                Email = "admin@gmail.com",
                LastUpdatedBy = "SYSTEM",
                LastUpdatedDate = DateTime.Now
            };

            admin.PasswordHash = PasswordGenerate(admin);
            builder.HasData(admin);
        }

        public string PasswordGenerate(User user)
        {
            var passHash = new PasswordHasher<User>();
            return passHash.HashPassword(user, "Abc123");
        }
    }
}
