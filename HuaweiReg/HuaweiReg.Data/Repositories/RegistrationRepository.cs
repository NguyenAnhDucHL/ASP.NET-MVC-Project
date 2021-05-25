using System;
using System.Collections.Generic;
using System.Text;
using HuaweiReg.Data.IRepositories;
using HuaweiReg.Data.Models;
using HuaweiReg.Data.Repositories.Generic;
using Microsoft.AspNetCore.Http;

namespace HuaweiReg.Data.Repositories
{
    public class RegistrationRepository: GenericTrackedRepository<Registration>, IRegistrationRepository
    {
        public RegistrationRepository(HuaweiDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {
        }
    }
}
