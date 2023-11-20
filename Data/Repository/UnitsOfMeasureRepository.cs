using Core;
using Entity;

namespace Data.Repository
{
    public class UnitsOfMeasureRepository : Repository<UnitsOfMeasure>, IUnitsOfMeasureRepository
    {
        public UnitsOfMeasureRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}