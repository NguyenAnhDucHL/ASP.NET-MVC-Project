using System;
using System.Collections.Generic;
using System.Text;
using HuaweiReg.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuaweiReg.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private const string adminRoleId = "F89F39DE-D9B1-4B2A-9857-AD2C7F4895E5";
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(new IdentityRole
            {
                Id = adminRoleId,
                Name = UserRole.ADMIN.ToString()
            });
        }
    }
}
