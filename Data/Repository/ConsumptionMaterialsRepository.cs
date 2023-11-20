using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class ConsumptionMaterialsRepository : Repository<ConsumptionMaterials>, IConsumptionMaterialsRepository
    {
        Erp_Context _erp_Context;
        public ConsumptionMaterialsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<ConsumptionMaterials> GetAllConsumptionMaterial()
        {
            var query = _erp_Context.ConsumptionMaterials
                .Include(x=>x.UnitsOfMeasure)
                .Include(x=>x.Companies)
                .Include(x => x.ConsumptionMaterialSuppliers)
                .ThenInclude(x=>x.Companies)
                .Include(x=>x.Currencies)
                .AsSplitQuery()
                .AsNoTracking();
            return query;
        }

        public IQueryable<ConsumptionMaterialStock> GetAllMaterialStock()
        {
            var query = _erp_Context.ConsumptionMaterialStock.AsSplitQuery()
                 .Include(x => x.Companies)
                 .Include(x => x.ConsumptionMaterials)
                 .Include(x => x.Stores)
                 .AsNoTracking();
            return query;
        }

        public IQueryable<ConsumptionMaterials> GetByConsumptionDetail(int id)
        {
            var result = _erp_Context.ConsumptionMaterials
                .Include(x => x.UnitsOfMeasure)
                .Include(x => x.Companies)
                .Include(x => x.Currencies)
                .Include(x => x.ConsumptionMaterialSuppliers)
                .ThenInclude(x => x.Companies).AsNoTracking().Where(x => x.Id == id);
            return result;
        }

        public IQueryable<ConsumptionMaterialStock> GetByIdStock(int id)
        {
            var query = _erp_Context.ConsumptionMaterialStock.AsSplitQuery()
                .Include(x => x.Companies)
                .Include(x => x.ConsumptionMaterials)
                .Include(x => x.Stores)
                .AsNoTracking().Where(x => x.Id == id);
            return query;
        }
    }
}