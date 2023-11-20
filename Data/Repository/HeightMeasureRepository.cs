using Core;
using Entity;

namespace Data.Repository
{
    public class HeightMeasureRepository : Repository<HeightMeasure>, IHeightMeasureRepository
    {
        Erp_Context _erp_Context;
        public HeightMeasureRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}
