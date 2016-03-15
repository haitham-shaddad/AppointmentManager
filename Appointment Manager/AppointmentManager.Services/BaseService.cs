
using AppointmentManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Services
{
    public class BaseService<T, K> : IService<T, K> where T : class
    {
        private IRepository<T, K> _repository;

        public BaseService(IRepository<T, K> repository)
        {
            this._repository = repository;
        }

        public T Add(T item)
        {
            return _repository.Add(item);
        }

        public bool Delete(T item)
        {
            return _repository.Delete(item);
        }

        public bool DeleteByID(K id)
        {
            return _repository.DeleteByID(id);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _repository.Find(predicate);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, int pageIndex, int pageSize, Expression<Func<T, K>> orderBy)
        {
            return _repository.Find(predicate, pageIndex, pageSize, orderBy);
        }

        public IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public IQueryable<T> GetAll(Expression<Func<T, K>> orderBy)
        {
            return _repository.GetAll(orderBy);
        }

        public IQueryable<T> GetAll(int pageIndex, int pageSize)
        {
            return _repository.GetAll(pageIndex, pageSize);
        }

        public IQueryable<T> GetAll(int pageIndex, int pageSize, Expression<Func<T, K>> orderBy)
        {
            return _repository.GetAll(pageIndex, pageSize, orderBy);
        }

        public T GetByID(K id)
        {
            return _repository.GetByID(id);
        }

        public bool Update(T item)
        {
            return _repository.Update(item);
        }
    }
}
