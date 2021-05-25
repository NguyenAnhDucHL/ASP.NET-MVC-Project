using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HuaweiReg.Data.Models;
using HuaweiReg.Service.ServiceModels;

namespace HuaweiReg.Service.IServices
{
    public interface IRegistrationService
    {
        Task<List<RegistrationModel>> GetAllRegistrations();
        Task AddRegistrationAsync(RegistrationModel model);
    }
}
