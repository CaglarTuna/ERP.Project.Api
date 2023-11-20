using Core;
using Entity;

namespace Data.Repository
{
    public class RejectionRepository : Repository<Rejection>, IRejectionRepository
    {
        Erp_Context _erp_Context;
        public RejectionRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}
