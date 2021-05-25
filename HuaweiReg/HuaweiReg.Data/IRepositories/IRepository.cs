using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HuaweiReg.Data.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
        Task<int> BulkInsertAsync(IList<T> items);
        Task<bool> BulkDeleteAsync(IList<T> items);
        Task<int> BulkUpdateAsync(IList<T> items);
        Task<IQueryable<T>> GetAllAsync(string include = "");
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, string include = "");
        Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate, string include = "");
    }
}
