using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repository
{
    public class ProductStockRepository : Repository<ProductStock>, IProductStockRepository
    {
        Erp_Context _erp_Context;
        public ProductStockRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<Products> ProductStock(int id)
        {
            var resutl = _erp_Context.Products
                .Include(x => x.ProductStock).ThenInclude(x => x.Stores)
                .Include(x => x.OrderProducts).ThenInclude(x => x.Orders)
                .Where(x => x.Id == id).AsNoTracking().AsSplitQuery();
            return resutl;
        }
    }
}