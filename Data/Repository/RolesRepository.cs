using Core;
using Entity;

namespace Data.Repository
{
    public class RolesRepository : Repository<Roles>, IRolesRepository
    {
        public RolesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}