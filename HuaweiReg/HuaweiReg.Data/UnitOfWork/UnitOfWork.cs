using System;
using System.Collections.Generic;
using System.Text;
using HuaweiReg.Data.IRepositories;
using HuaweiReg.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Design;

namespace HuaweiReg.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HuaweiDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private IRegistrationRepository _registrationRepository;
        //public UnitOfWork(IDbContextFactory<HuaweiDbContext> dbContextFactory, IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //    _context = dbContextFactory.GetContext();
        //}
        public UnitOfWork(IDbContextFactory<HuaweiDbContext> dbContextFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = dbContextFactory.GetContext();
        }

        public IRegistrationRepository RegistrationRepository
        {
            get
            {
                return _registrationRepository = _registrationRepository ?? new RegistrationRepository(_context, _httpContextAccessor);
            }

        }

        #region Dispose
        private bool _disposed;     
        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
        }

        #endregion
    }
}
