using Core;
using Entity;

namespace Data.Repository
{
    public class StaffProcessPermisionsRepository : Repository<StaffProcessPermisions>, IStaffProcessPermisionsRepository
    {
        public StaffProcessPermisionsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}