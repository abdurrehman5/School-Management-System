using Data;
using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
namespace Repository.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        //protected StudentContext context { get; set; }
        private readonly StudentContext _context;
        public BaseRepository(StudentContext repositoryContext)
        {
            _context = repositoryContext;
        }
        public T Add(T entity)
        {
            _context.Set<T>().Add(entity);
            SaveChanges();
            return entity;
        }
        public IEnumerable<T> BulkInsert(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
            SaveChanges();
            return entities;
        }
        public IEnumerable<T> BulkUpdate(IEnumerable<T> entities)
        {
            _context.Set<T>().UpdateRange(entities);
            SaveChanges();
            return entities;
        }
        public IEnumerable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression).AsNoTracking();
        }
        public IEnumerable<T> Get()
        {
            return _context.Set<T>().AsNoTracking();
        }
        public async Task<IReadOnlyList<T>> GetAll(
           Expression<Func<T, bool>> filter,
           params Expression<Func<T, object>>[] includes)
        {
            return await GetAllIncluding(includes).Where(filter).ToListAsync();
        }
        private IQueryable<T> GetAllIncluding
            (params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> queryable = _context.Set<T>().AsNoTracking();
            return includeProperties.Aggregate
                (queryable, (current, includeProperty) => current.Include(includeProperty));
        }
        public T Get(int id)
        {
            return _context.Set<T>().Find(id);
        }
        public T Remove(int Id)
        {
            var entity = _context.Set<T>().Find(Id);
            if (entity == null)
            {
                return entity;
            }
            //    context.Set<T>().Remove(entity);
            _context.Set<T>().Remove(entity);
            SaveChanges();
            return entity;
        }
        public T Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            SaveChanges();
            return entity;
        }
        public IEnumerable<T> BulkDelete(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            SaveChanges();
            return entities;
        }
        public T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return entity;
        }
        //public  async Task<T> Add(T entity)
        //{
        //    context.Set<T>().Add(entity);
        //    await context.SaveChangesAsync();
        //    return entity;
        //}
        //public  async Task<T> Delete(int id)
        //{
        //    var entity = await context.Set<T>().FindAsync(id);
        //    if (entity == null)
        //    {
        //        return entity;
        //    }
        //    context.Set<T>().Remove(entity);
        //    await context.SaveChangesAsync();
        //    return entity;
        //}
        //public  async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression)
        //{
        //    return await context.Set<T>().Where(expression).AsNoTracking().ToListAsync();
        //}
        //public  async Task<T> Get(int id)
        //{
        //    return await context.Set<T>().FindAsync(id);
        //}
        //public  async Task<List<T>> GetAll()
        //{
        //    return await context.Set<T>().ToListAsync();
        //}
        //public  async Task<T> Update(T entity)
        //{
        //    context.Entry(entity).State = EntityState.Modified;
        //    await context.SaveChangesAsync();
        //    return entity;
        //}
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

    }
    public interface IBaseRepository<T> where T : class
    {
        //Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression);
        //Task<List<T>> GetAll();
        //Task<T> Get(int id);
        //Task<T> Add(T entity);
        //Task<T> Update(T entity);
        //Task<T> Delete(int id);
        // int SaveChanges();
        T Get(int id);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
        T Add(T entity);
        IEnumerable<T> BulkInsert(IEnumerable<T> entities);
        IEnumerable<T> BulkUpdate(IEnumerable<T> entities);
        T Remove(int Id);
        IEnumerable<T> BulkDelete(IEnumerable<T> entities);
        T Update(T entity);
        T Remove(T entity);
    }
}
