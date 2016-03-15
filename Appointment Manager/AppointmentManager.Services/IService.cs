using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentManager.Services
{
    public interface IService<T, K> where T : class
    {
        T Add(T item);

        bool Update(T item);

        bool DeleteByID(K id);

        bool Delete(T item);

        T GetByID(K id);

        IQueryable<T> GetAll();

        IQueryable<T> GetAll(Expression<Func<T, K>> orderBy);

        IQueryable<T> GetAll(int pageIndex, int pageSize);

        IQueryable<T> GetAll(int pageIndex, int pageSize, Expression<Func<T, K>> orderBy);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate, int pageIndex, int pageSize, Expression<Func<T, K>> orderBy);
    }
}
