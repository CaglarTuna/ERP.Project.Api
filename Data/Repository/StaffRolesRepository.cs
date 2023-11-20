using Core;
using Entity;

namespace Data.Repository
{
    public class StaffRolesRepository : Repository<StaffRoles>, IStaffRolesRepository
    {
        public StaffRolesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}