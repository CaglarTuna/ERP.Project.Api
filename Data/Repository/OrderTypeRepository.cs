using Core;
using Entity;

namespace Data.Repository
{
    public class OrderTypeRepository : Repository<OrderType>, IOrderTypeRepository
    {
        Erp_Context _erp_Context;
        public OrderTypeRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}
