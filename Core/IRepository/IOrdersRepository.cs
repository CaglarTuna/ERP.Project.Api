using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public interface IOrdersRepository : IRepository<Orders>
    {
        IQueryable<Orders> GetAllOrder();
        Orders GetByOrderId(int id);
        IQueryable<Orders> GetByOrdersDetail(int id);
        IQueryable<Orders> GetOrderProduction();
    }
}
