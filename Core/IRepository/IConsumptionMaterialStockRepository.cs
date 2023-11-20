using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public interface IConsumptionMaterialStockRepository : IRepository<ConsumptionMaterialStock>
    {
        IQueryable<ConsumptionMaterialStock> GetAllMaterialStock();
        IQueryable<ConsumptionMaterialStock> GetByIdStock(int id);
    }
}
