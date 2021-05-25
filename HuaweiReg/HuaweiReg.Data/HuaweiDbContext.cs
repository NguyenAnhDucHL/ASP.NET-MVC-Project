using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using HuaweiReg.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HuaweiReg.Data
{
    public class HuaweiDbContext : IdentityDbContext<User>
    {
        public HuaweiDbContext(DbContextOptions<HuaweiDbContext> options) : base(options)
        {
            
        }

        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            //This will pick up all configurations that are defined in the assembly
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //Instead of this:
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
            //...
            base.OnModelCreating(modelBuilder);
        }
    }
}
