using Core;
using Entity;

namespace Data.Repository
{
    public class MaterialHeightMeasureRepository : Repository<MaterialHeightMeasure>, IMaterialHeightMeasureRepository
    {
        Erp_Context _erp_Context;
        public MaterialHeightMeasureRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}
