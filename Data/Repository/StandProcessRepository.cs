using Core;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class StandProcessRepository : Repository<StandProcess>, IStandProcessRepository
    {
        Erp_Context _erp_Context;
        public StandProcessRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}