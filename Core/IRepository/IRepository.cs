using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetBy(Expression<Func<T, bool>> predicate);
        T GetById(int id);
        void Delete(T entitiy);
        T Update(T entitiy);
        T Add(T entitiy);
        bool AddRange(List<T> entitiy);
        bool UpdateRange(List<T> entitiy);
        void DeleteRange(List<T> entitiy);
    }
}
