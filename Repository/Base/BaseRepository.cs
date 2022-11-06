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
    
    public  class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        //protected StudentContext context { get; set; }
        private readonly StudentContext context;
        public BaseRepository(StudentContext repositoryContext)
        {
            context = repositoryContext;
        }
        public  async Task<T> Add(T entity)
        {
            context.Set<T>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public  async Task<T> Delete(int id)
        {
            var entity = await context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }
        public  async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return await context.Set<T>().Where(expression).AsNoTracking().ToListAsync();

        }

        public  async Task<T> Get(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public  async Task<List<T>> GetAll()
        {
            return await context.Set<T>().ToListAsync();
        }

        public  async Task<T> Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

        public virtual int  SaveChanges()
        {
           return  context.SaveChanges();
        }
    }

    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        int SaveChanges();
    }
}
