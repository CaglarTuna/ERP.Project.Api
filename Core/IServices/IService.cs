using System.Collections.Generic;

namespace Core.IServices
{
    public interface IService<T> where T : class
    {
        List<T> GetAll(int languageId);
        List<T> GetBy(int languageId);
        T GetById(int id,int languageId);
        bool Delete(int id);
        bool Update(T entitiy);
        void Add(T entitiy);
    }
}
