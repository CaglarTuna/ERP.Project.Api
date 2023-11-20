using Entity;
using System.Linq;

namespace Core
{
    public interface IProductStockRepository : IRepository<ProductStock>
    {
        IQueryable<Products> ProductStock(int id);
    }

}
