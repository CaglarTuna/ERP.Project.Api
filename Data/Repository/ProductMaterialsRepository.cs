using Core;
using Entity;

namespace Data.Repository
{
    public class ProductMaterialsRepository : Repository<ProductMaterials>, IProductMaterialsRepository
    {
        public ProductMaterialsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}