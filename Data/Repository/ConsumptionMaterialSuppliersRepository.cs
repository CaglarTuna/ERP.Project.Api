using Core;
using Entity;

namespace Data.Repository
{
    public class ConsumptionMaterialSuppliersRepository : Repository<ConsumptionMaterialSuppliers>, IConsumptionMaterialSuppliersRepository
    {
        public ConsumptionMaterialSuppliersRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}