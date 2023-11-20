using Core;
using Entity;

namespace Data.Repository
{
    public class MaterialSuppliersRepository : Repository<MaterialSuppliers>, IMaterialSuppliersRepository
    {
        public MaterialSuppliersRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}