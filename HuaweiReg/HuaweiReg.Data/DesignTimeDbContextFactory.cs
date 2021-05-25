using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic;
using Constants = HuaweiReg.Common.Constants;

namespace HuaweiReg.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HuaweiDbContext>
    {
        public HuaweiDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString(Constants.Database.HuaweiConnectionStringName);

            var optionsBuilder = new DbContextOptionsBuilder<HuaweiDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new HuaweiDbContext(optionsBuilder.Options);
        }
    }
}
