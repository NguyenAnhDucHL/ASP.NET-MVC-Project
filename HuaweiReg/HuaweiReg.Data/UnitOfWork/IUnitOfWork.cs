using System;
using System.Collections.Generic;
using System.Text;
using HuaweiReg.Data.IRepositories;

namespace HuaweiReg.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IRegistrationRepository RegistrationRepository { get; }
    }
}
