using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class MaterialExpertDeliverysRepository : Repository<MaterialExpertDeliverys>, IMaterialExpertDeliverysRepository
    {
        Erp_Context _erp_Context;
        public MaterialExpertDeliverysRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<MaterialExpertDeliverys> GetAllDeliverys()
        {
            var result = _erp_Context.MaterialExpertDeliverys.AsSplitQuery()
                .Include(x => x.Staffs)
                .Include(x => x.Materials)
                .ThenInclude(x => x.MaterialHeightMeasures)
                .ThenInclude(x => x.HeightMeasures).AsNoTracking();
            return result;   
        }
    }
}