using Core;
using Entity;

namespace Data.Repository
{
    public class MaterialShapeRepository : Repository<MaterialShape>, IMaterialShapeRepository
    {
        Erp_Context _erp_Context;
        public MaterialShapeRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}
