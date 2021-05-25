using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace HuaweiReg.Data
{
    public class HuaweiDbContextFactory : IDbContextFactory<HuaweiDbContext>
    {
        private readonly DbContextOptions<HuaweiDbContext> _options;
        private HuaweiDbContext _context;

        public HuaweiDbContextFactory(DbContextOptions<HuaweiDbContext> options)
        {
            _options = options;
        }
        public HuaweiDbContext GetContext()
        {
            if (_context == null)
            {
                _context = new HuaweiDbContext(_options);
            }

            return _context;
        }
    }
}
