using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Persistence.Repository
{
    public interface IRepository<T, Pk> where T : class
    {
        void Add(T entity);
        Task<EntityEntry<T>> AddAsync(T entity);
        void Update(T entity);
        void Remove(T entity);
        Task Remove(Pk Id);
        void AddRange(IEnumerable<T> entities);
        void RemoveRange(IEnumerable<T> entities);
        Task<T> GetById(Pk id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null, string includeProperties = null, bool tracked = false);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, string includeProperties = null, bool tracked = false);

          IQueryable<TResult> GetAllIncluding<TResult>(Expression<Func<T, TResult>> selector,
                                               Expression<Func<T, bool>> predicate = null,
                                               Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                               Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                               bool disableTracking = true);
    }
}
