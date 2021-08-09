using Microsoft.EntityFrameworkCore;
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
    public class Repository<T, Pk> : IRepository<T, Pk> where T : class
    {
        protected readonly ApplicationDbContext db;

        public Repository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
        }
        public async Task<EntityEntry<T>> AddAsync(T entity)
        {
           return await db.Set<T>().AddAsync(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            db.Set<T>().AddRange(entities);
        }
         
        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate=null, string includeProperties=null  ,bool tracked=false  )
        {
            IQueryable<T> query = db.Set<T>();
            query = tracked ? query.AsTracking() : query.AsNoTracking();
            query = predicate != null ? query.Where(predicate) : query;

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (string includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }
         

            return  query;
        }     
        
        
        //public IQueryable<T> GetAlla(Expression<Func<T, bool>> predicate=null, List<Expression<Func<T, object>>> Includes=null ,string includeProperties =null  ,bool tracked=false  )
        //{
        //    IQueryable<T> query = db.Set<T>();
        //    query = tracked ? query.AsTracking() : query.AsNoTracking();
        //    query = predicate != null ? query.Where(predicate) : query;

        //    if (!string.IsNullOrEmpty(includeProperties))
        //    {
        //        foreach (string includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //        {
        //            query = query.Include(includeProperty);
        //        }
        //    }
         

        //    return  query;
        //}


        /// <summary>
        /// Gets the first or default entity based on a predicate, orderby delegate and include delegate. This method default no-tracking query.
        /// </summary>
        /// <param name="selector">The selector for projection.</param>
        /// <param name="predicate">A function to test each element for a condition.</param>
        /// <param name="orderBy">A function to order elements.</param>
        /// <param name="include">A function to include navigation properties</param>
        /// <param name="disableTracking"><c>True</c> to disable changing tracking; otherwise, <c>false</c>. Default to <c>true</c>.</param>
        /// <returns>An <see cref="IPagedList{TEntity}"/> that contains elements that satisfy the condition specified by <paramref name="predicate"/>.</returns>
        /// <remarks>This method default no-tracking query.</remarks>
        public TResult GetFirstOrDefault<TResult>(Expression<Func<T, TResult>> selector,
                                                  Expression<Func<T, bool>> predicate = null,
                                                  Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                  Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                                  bool disableTracking = true)
        {
            IQueryable<T> query = db.Set<T>();
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(selector).FirstOrDefault();
            }
            else
            {
                return query.Select(selector).FirstOrDefault();
            }
        }


        public IQueryable<TResult> GetAllIncluding<TResult>(Expression<Func<T, TResult>> selector,
                                              Expression<Func<T, bool>> predicate = null,
                                              Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                              Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null,
                                              bool disableTracking = true)
        {
            IQueryable<T> query = db.Set<T>();
            if (disableTracking)
            {
                query = query.AsNoTracking();
            }

            if (include != null)
            {
                query = include(query);
            }

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                return orderBy(query).Select(selector).AsQueryable();
            }
            else
            {
                return query.Select(selector).AsQueryable();
            }


        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate, string includeProperties = null, bool tracked = false)
        {
            IQueryable<T> query = db.Set<T>();

            query = tracked ? query.AsTracking() : query.AsNoTracking();

            query = predicate != null ? query.Where(predicate) : query;

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (string includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }

            }

            return await query.FirstOrDefaultAsync();
        }
         
        public async Task<T> GetById(Pk id)
        {
            return await db.Set<T>().FindAsync(id);
        }
         
        public void Remove(T entity)
        {
            db.Set<T>().Remove(entity);
        }

        public async Task Remove(Pk Id)
        {
            var entity = await db.Set<T>().FindAsync(Id);
            if (entity == null)
            {
                throw new Exception("No Entity Found");
            }
            db.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            db.Set<T>().RemoveRange(entities);
        }

        public void Update(T entity)
        {
            db.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }


    }
}
