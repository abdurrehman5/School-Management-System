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

        public  T Add(T entity)       
        {
             this.WhileInserting(entity);
            var InsertEntity =  _baseRepository.Add(entity);
            this.OnInserting(InsertEntity);
            return InsertEntity;
        }

        public IEnumerable<T> BulkInsert(IEnumerable<T> entities)
        {
            this.WhileInserting(entities);
            var InsertEntity = _baseRepository.BulkInsert(entities);
            this.OnInserting(entities);
            return InsertEntity;
        }

        public IEnumerable<T> BulkUpdate(IEnumerable<T> entities)
        {
            this.WhileUpdating(entities);
            var InsertEntity = _baseRepository.BulkInsert(entities);
            this.OnUpdating(entities);
            return InsertEntity;
        }
        public IEnumerable<T> BulkDelete(IEnumerable<T> entities)
        {
            var InsertEntity = _baseRepository.BulkDelete(entities);
            return InsertEntity;
        }
        public T Delete(int Id)
        {
           return  _baseRepository.Remove(Id);

        }

        public T Delete(T entity)
        {
            return _baseRepository.Remove(entity);

        }

        public  IEnumerable<T> Get(Expression<Func<T, bool>> expression)
        {
            return  _baseRepository.Get(expression);

        }

        public async Task<T> Get(int id)
        {
            return  _baseRepository.Get(id);
        }

        public IEnumerable<T> Get()
        {
            return  _baseRepository.Get();
        }

        public T Update(T entity)
        {
             this.WhileUpdating(entity);
            var UpdateEntity =   _baseRepository.Update(entity);
             this.OnUpdating(UpdateEntity);
            return UpdateEntity;
        }
        public virtual  void WhileInserting(T entities)
        {         
        }
        public virtual  void OnInserting(T entities)
        {
        }
        public virtual  void WhileUpdating(T entities)
        {

        }
        public virtual  void OnUpdating(T entities)
        { 
        }


        public virtual void WhileInserting(IEnumerable<T> entities)
        {
        }
        public virtual void OnInserting(IEnumerable<T> entities)
        {
        }
        public virtual void WhileUpdating(IEnumerable<T> entities)
        {

        }
        public virtual void OnUpdating(IEnumerable<T> entities)
        {
        }

        T IBaseService<T>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }

    public interface IBaseService<T> where T : class
    {
        T Add(T entity);
        T Update(T entity);
        IEnumerable<T> Get();
        T Get(int id);
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
        T Delete(T entity);
        T Delete(int Id);
        IEnumerable<T> BulkInsert(IEnumerable<T> entities);
        IEnumerable<T> BulkUpdate(IEnumerable<T> entities);
        IEnumerable<T> BulkDelete(IEnumerable<T> entities);
    }
}
