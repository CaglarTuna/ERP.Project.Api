using DTO;
using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public interface IOrderProductsRepository : IRepository<OrderProducts>
    {
        IQueryable<OrderProducts> OrderProducts();
        IQueryable<OrderProducts> GetByIdOrderProducts(int id, int ordeId);
        
    }
}
