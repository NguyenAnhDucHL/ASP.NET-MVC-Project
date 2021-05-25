using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using HuaweiReg.Data.IRepositories;
using LinqKit;
using Microsoft.EntityFrameworkCore;

namespace HuaweiReg.Data.Repositories.Generic
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly HuaweiDbContext _context;
        public GenericRepository(HuaweiDbContext dbContext)
        {
            _context = dbContext;

        }
        public virtual async Task<T> AddAsync(T entity)
        {
            var result = _context.Set<T>().Add(entity);
            var insertedRows = await _context.SaveChangesAsync();

            if (insertedRows > 0)
                return result.Entity;
            else
                return null;
        }
        public virtual async Task UpdateAsync(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _context.Set<T>().Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            }

            await _context.SaveChangesAsync();
        }
        public virtual async Task<bool> BulkDeleteAsync(IList<T> items)
        {
            if (items.Any())
            {
                using (var scope = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
                {
                    try
                    {
                        foreach (var entity in items)
                        {
                            if (_context.Entry(entity).State == EntityState.Detached)
                            {
                                _context.Set<T>().Attach(entity);
                                _context.Set<T>().Remove(entity);
                            }

                        }
                        await _context.SaveChangesAsync();
                        scope.Commit();
                    }
                    catch (Exception)
                    {
                        scope.Rollback();
                        throw;
                    }
                }
            }
            return true;
        }
        public virtual async Task<int> BulkInsertAsync(IList<T> items)
        {
            using (var scope = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                try
                {
                    _context.Set<T>().AddRange(items);
                    var result = await _context.SaveChangesAsync();
                    scope.Commit();
                    return result;
                }
                catch (Exception)
                {
                    scope.Rollback();
                    throw;
                }
            }
        }
        public virtual async Task<int> BulkUpdateAsync(IList<T> items)
        {
            using (var scope = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadCommitted))
            {
                try
                {
                    foreach (var entity in items)
                    {
                        if (_context.Entry(entity).State == EntityState.Detached)
                        {
                            _context.Set<T>().Attach(entity);
                            _context.Entry(entity).State = EntityState.Modified;
                        }
                    }
                    await _context.SaveChangesAsync();
                    scope.Commit();
                    return items.Count;
                }
                catch (Exception)
                {
                    scope.Rollback();
                    throw;
                }
            }
        }
        public virtual async Task DeleteAsync(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _context.Set<T>().Attach(entity);
                _context.Set<T>().Remove(entity);
                await _context.SaveChangesAsync();
            }
        }
        public virtual async Task<IQueryable<T>> FindByAsync(Expression<Func<T, bool>> predicate, string include = "")
        {
            var query = _context.Set<T>().Where(predicate).AsQueryable<T>().AsNoTracking();
            query = BuildIncludeQuery(query, include).AsExpandable();

            return await Task.FromResult(query);
        }
        public virtual async Task<T> GetAsync(Expression<Func<T, bool>> predicate, string include = "")
        {
            var query = _context.Set<T>().AsQueryable<T>().AsNoTracking();
            query = BuildIncludeQuery(query, include).AsExpandable();
            return await query.Where(predicate).FirstOrDefaultAsync();
        }
        public virtual async Task<IQueryable<T>> GetAllAsync(string include = "")
        {
            var query = _context.Set<T>().AsQueryable<T>().AsNoTracking();
            query = BuildIncludeQuery(query, include).AsExpandable();
            return await Task.FromResult(query);
        }

        public IQueryable<T> BuildIncludeQuery(IQueryable<T> query, string include)
        {
            if (string.IsNullOrWhiteSpace(include))
                return query;

            var includeEntities = include.Split(',');
            if (includeEntities == null || !includeEntities.Any())
                return query;

            foreach (var entity in includeEntities)
            {
                query = query.Include(entity);
            }

            return query;
        }

    }
}
