using Microsoft.EntityFrameworkCore;
using Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.Base
{
    public  class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _baseRepository;
        public BaseService( IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public async Task<T> Add(T entity)
        {
            this.WhileInserting(entity);
            var InsertEntity = await _baseRepository.Add(entity);
            this.OnInserting(InsertEntity);
            return InsertEntity;
        }

        public async Task<T> Delete(int id)
        {

           return await  _baseRepository.Delete(id);

        }
        public async Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return await _baseRepository.FindByCondition(expression);

        }

        public async Task<T> Get(int id)
        {
            return await _baseRepository.Get(id);
        }

        public async Task<List<T>> GetAll()
        {
            return await _baseRepository.GetAll();
        }

        public async Task<T> Update(T entity)
        {
            this.WhileUpdating(entity);
            var UpdateEntity =  await _baseRepository.Update(entity);
            this.OnUpdating(UpdateEntity);
            return UpdateEntity;
        }
        public virtual void WhileInserting(T entity)
        {         
        }
        public virtual void OnInserting(T entity)
        {
        }
        public virtual void WhileUpdating(T entity)
        { 
        }
        public virtual void OnUpdating(T entity)
        { 
        }


    }

    public interface IBaseService<T> where T : class
    {
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<List<T>> GetAll();
        Task<T> Get(int id);
        Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task<T> Delete(int id);
    }
}
