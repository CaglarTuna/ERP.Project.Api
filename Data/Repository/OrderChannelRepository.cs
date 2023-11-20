using Core;
using Entity;

namespace Data.Repository
{
    public class OrderChannelRepository : Repository<OrderChannel>, IOrderChannelRepository
    {
        public OrderChannelRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}