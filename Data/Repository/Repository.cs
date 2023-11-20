using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Erp_Context _erp_Context;
        DbSet<T> _dbSet;
        public Repository(Erp_Context erp_Context)
        {
            _erp_Context = erp_Context;
            _dbSet = _erp_Context.Set<T>();
        }
        public T Add(T entitiy)
        {
            _dbSet.Add(entitiy);
            return entitiy;
        }

        public bool AddRange(List<T> entitiy)
        {
            _dbSet.AddRange(entitiy);
            return true;
        }

        public void Delete(T entitiy)
        {
            _dbSet.Remove(entitiy);
        }

        public void DeleteRange(List<T> entitiy)
        {
            _dbSet.RemoveRange(entitiy);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<T> GetBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }


        public T Update(T entitiy)
        {
            _dbSet.Update(entitiy);
            return entitiy;
        }

        public bool UpdateRange(List<T> entitiy)
        {
            _dbSet.UpdateRange(entitiy);
            return true;
        }
    }
}
