using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HuaweiReg.Data.IRepositories;
using Microsoft.AspNetCore.Http;

namespace HuaweiReg.Data.Repositories.Generic
{
    public abstract class GenericTrackedRepository<T> : GenericRepository<T> where T : class, ITrackedEntity
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        protected GenericTrackedRepository(HuaweiDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        protected string CurrentUser =>
            _httpContextAccessor != null && _httpContextAccessor.HttpContext != null && _httpContextAccessor.HttpContext.User.Identity.IsAuthenticated
                ? _httpContextAccessor.HttpContext.User.Identity.Name
                : "Unknown";

        public override async Task<T> AddAsync(T entity)
        {
            entity.LastUpdatedDate = DateTime.Now;
            entity.LastUpdatedBy = CurrentUser;
            return await base.AddAsync(entity);
        }

        public override async Task UpdateAsync(T entity)
        {
            entity.LastUpdatedDate = DateTime.Now;
            entity.LastUpdatedBy = CurrentUser;
            await base.UpdateAsync(entity);
        }

        public override async Task<int> BulkUpdateAsync(IList<T> items)
        {
            return await base.BulkUpdateAsync(items.Select(x =>
            {
                x.LastUpdatedDate = DateTime.Now;
                x.LastUpdatedBy = CurrentUser;
                return x;
            }).ToList());
        }
        public override async Task<int> BulkInsertAsync(IList<T> items)
        {
            return await base.BulkInsertAsync(items.Select(x =>
            {
                x.LastUpdatedDate = DateTime.Now;
                x.LastUpdatedBy = this.CurrentUser;
                return x;

            }).ToList());
        }
    }
}
