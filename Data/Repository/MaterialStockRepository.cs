using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class MaterialStockRepository : Repository<MaterialStock>, IMaterialStockRepository
    {
        Erp_Context _erp_Context;
        public MaterialStockRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<MaterialStock> GetAllStock()
        {
            var query = _erp_Context.MaterialStock
                .Include(x => x.Materials).ThenInclude(x=>x.Currencies)
                .Include(x=>x.Materials).ThenInclude(x=>x.HeightMeasure)
                .Include(x=>x.Companies)
                .Include(x=>x.Stores)
                .Include(x=>x.Materials).ThenInclude(x=>x.OrderMaterials).ThenInclude(x=>x.Orders)
                .AsNoTracking().AsSplitQuery();
            return query;
        }
    }
}