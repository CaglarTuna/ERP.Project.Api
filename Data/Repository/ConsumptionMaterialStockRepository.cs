using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class ConsumptionMaterialStockRepository : Repository<ConsumptionMaterialStock>, IConsumptionMaterialStockRepository
    {
        Erp_Context _erp_Context;
        public ConsumptionMaterialStockRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<ConsumptionMaterialStock> GetAllMaterialStock()
        {
            var query = _erp_Context.ConsumptionMaterialStock.AsSplitQuery()
                 .Include(x => x.Companies)
                 .Include(x=>x.ConsumptionMaterials).ThenInclude(x=>x.UnitsOfMeasure)
                 .Include(x => x.ConsumptionMaterials)
                 .ThenInclude(x => x.Currencies)
                 .Include(x => x.Stores)
                 .Include(x => x.Staffs)
                 .Include(x => x.Stands)
                 .Include(x => x.Orders)
                 .AsNoTracking();
            return query;
        }

        public IQueryable<ConsumptionMaterialStock> GetByIdStock(int id)
        {
            var query = _erp_Context.ConsumptionMaterialStock.AsSplitQuery()
               .Include(x => x.Companies)
               .Include(x => x.ConsumptionMaterials).ThenInclude(x => x.Currencies)
               .Include(x => x.Stores)
               .Include(x => x.Staffs)
               .Include(x => x.Stands)
               .Include(x => x.Orders)
               .AsNoTracking().Where(x => x.Id == id);
            return query;
        }
    }
}