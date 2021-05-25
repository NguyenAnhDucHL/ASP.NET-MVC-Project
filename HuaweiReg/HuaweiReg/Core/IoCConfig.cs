using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HuaweiReg.Common;
using HuaweiReg.Data;
using HuaweiReg.Data.Models;
using HuaweiReg.Data.UnitOfWork;
using HuaweiReg.Service.IServices;
using HuaweiReg.Service.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HuaweiReg.Web.Core
{
    public static class IoCConfig
    {
        public static void Register(IServiceCollection services, IConfiguration configuration)
        {
            // Context
            services.AddHttpContextAccessor();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();

            services.AddDbContext<HuaweiDbContext>(); // To fix error when creating a migration (come from yellow background)
            // Identity services
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<HuaweiDbContext>();

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                //options.Cookie.Expiration 
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.LoginPath = "/Identity/Account/Login";
                options.LogoutPath = "/Identity/Account/Logout";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
                //options.ReturnUrlParameter=""
            });

            // Db
            services.AddSingleton(new DbContextOptionsBuilder<HuaweiDbContext>().UseSqlServer(configuration.GetConnectionString(Constants.Database.HuaweiConnectionStringName)).Options);
            services.AddTransient<Data.IDbContextFactory<HuaweiDbContext>, HuaweiDbContextFactory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddTransient<IRegistrationService, RegistrationService>();

        }
    }
}
