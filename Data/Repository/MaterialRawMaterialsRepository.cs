using Core;
using Entity;

namespace Data.Repository
{
    public class MaterialRawMaterialsRepository : Repository<MaterialRawMaterials>, IMaterialRawMaterialsRepository
    {
        public MaterialRawMaterialsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}