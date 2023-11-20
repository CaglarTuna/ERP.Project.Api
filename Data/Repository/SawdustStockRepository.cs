using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class SawdustStockRepository : Repository<SawdustStock>, ISawdustStockRepository
    {
        Erp_Context _erp_Context;
        public SawdustStockRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public List<SawdustStock> sawdustStocks()
        {
            var query = _erp_Context.SawdustStock
                .Include(x => x.Companies)
                .Include(x => x.Materials)
                .Include(x => x.Stores)
                .Include(x=>x.Currencies)
                .Include(x=>x.Orders).AsNoTracking().AsSplitQuery().ToList();
            return query;
        }
    }
}