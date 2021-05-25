using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HuaweiReg.Data.Configuration
{
    public class UsersWithRolesConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        private const string adminId = "40DB3A70-9EE6-4CF3-997A-C6262C622A47";
        private const string adminRoleId = "F89F39DE-D9B1-4B2A-9857-AD2C7F4895E5";
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            IdentityUserRole<string> userInRole = new IdentityUserRole<string>
            {
                RoleId = adminRoleId,
                UserId = adminId
            };

            builder.HasData(userInRole);
        }
    }
}
