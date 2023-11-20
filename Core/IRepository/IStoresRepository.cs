using Entity;
using System.Linq;

namespace Core
{
    public interface IStoresRepository : IRepository<Stores>
    {
        IQueryable<Stores> GetAllWithStore();
        IQueryable<Stores> GetWithByIdStore(int id);
    }
}
