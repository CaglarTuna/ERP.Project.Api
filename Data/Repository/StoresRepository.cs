using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repository
{
    public class StoresRepository : Repository<Stores>, IStoresRepository
    {
        Erp_Context _erp_Context;

        public StoresRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }


        public IQueryable<Stores> GetAllWithStore()
        {
            return _erp_Context.Stores.AsNoTracking();
        }

        public IQueryable<Stores> GetWithByIdStore(int id)
        {
            return _erp_Context.Stores.Include(x => x.Id == id).AsNoTracking();
        }
    }
}