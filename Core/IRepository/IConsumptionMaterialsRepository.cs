using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public interface IConsumptionMaterialsRepository : IRepository<ConsumptionMaterials>
    {
        IQueryable<ConsumptionMaterials> GetAllConsumptionMaterial();
        IQueryable<ConsumptionMaterials> GetByConsumptionDetail(int id);
        IQueryable<ConsumptionMaterialStock> GetAllMaterialStock();
        IQueryable<ConsumptionMaterialStock> GetByIdStock(int id);

    }
}
