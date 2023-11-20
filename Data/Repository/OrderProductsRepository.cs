using Core;
using DTO;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class OrderProductsRepository : Repository<OrderProducts>, IOrderProductsRepository
    {
        Erp_Context _erp_Context;
        public OrderProductsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<OrderProducts> GetByIdOrderProducts(int id, int ordeId)
        {
            var result = _erp_Context.OrderProducts
                .Include(x => x.Statuss)
                .Include(x => x.Orders)
                .Include(x => x.Products)
                .ThenInclude(x => x.ProductMaterials).ThenInclude(x => x.Materials).ThenInclude(x => x.UnitsOfMeasure).Where(x => x.OrderId == ordeId && x.ProductId == id).AsNoTracking().AsSplitQuery();
            return result;
        }
        public IQueryable<OrderProducts> OrderProducts()
        {
            return _erp_Context.OrderProducts
                .Include(x => x.Statuss)
                .Include(x => x.Orders)
                .Include(x => x.Products)
                .ThenInclude(x => x.ProductMaterials)
                .ThenInclude(x => x.Materials).ThenInclude(x => x.MaterialSupplyRequests).ThenInclude(x => x.MaterialSupply)
                .Include(x => x.Products)
                .ThenInclude(x => x.Categories)
                .ThenInclude(x => x.CategoriesLanguage).AsNoTracking().AsSplitQuery();
        }
    }
}