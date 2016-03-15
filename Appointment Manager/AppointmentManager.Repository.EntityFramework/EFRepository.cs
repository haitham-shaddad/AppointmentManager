using AppointmentManager.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace AppointmentManager.Repository.EntityFramework
{
    public class EFRepository<T, K> : IRepository<T, K> where T : class
    {
        private DbContext _context;
        private DbSet<T> _entitySet;

        public EFRepository(DbContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            this._context = context;
            _entitySet = _context.Set<T>();
        }

        public T Add(T item)
        {
            _entitySet.Add(item);
            _context.SaveChanges();
            return item;
        }

        public bool Delete(T item)
        {
            _entitySet.Attach(item);
            _entitySet.Remove(item);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteByID(K id)
        {
            var item = _entitySet.Find(id);
            _entitySet.Remove(item);
            _context.SaveChanges();
            return true;
        }


        public T GetByID(K id)
        {
            return _entitySet.Find(id);
        }

        public IQueryable<T> GetAll()
        {
            return _entitySet;
        }

        public IQueryable<T> GetAll(Expression<Func<T, K>> orderBy)
        {
            return _entitySet.OrderBy(orderBy);
        }

        public IQueryable<T> GetAll(int pageIndex, int pageSize)
        {
            return _entitySet.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

        public IQueryable<T> GetAll(int pageIndex, int pageSize, Expression<Func<T, K>> orderBy)
        {
            return _entitySet.Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(orderBy);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _entitySet.Where(predicate);
        }

        public IQueryable<T> Find(Expression<Func<T, bool>> predicate, int pageIndex, int pageSize, Expression<Func<T, K>> orderBy)
        {
            return _entitySet.Where(predicate).Skip((pageIndex - 1) * pageSize).Take(pageSize).OrderBy(orderBy);
        }

        public bool Update(T item)
        {
            _entitySet.Attach(item);
            _context.SaveChanges();
            return true;
        }
    }
}
