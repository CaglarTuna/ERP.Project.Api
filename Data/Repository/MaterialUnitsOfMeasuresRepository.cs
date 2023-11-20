using Core;
using Entity;

namespace Data.Repository
{
    public class MaterialUnitsOfMeasuresRepository : Repository<MaterialUnitsOfMeasures>, IMaterialUnitsOfMeasuresRepository
    {
        public MaterialUnitsOfMeasuresRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}