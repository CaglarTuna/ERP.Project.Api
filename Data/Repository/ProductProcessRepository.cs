using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repository
{
    public class ProductProcessRepository : Repository<ProductProcess>, IProductProcessRepository
    {
        Erp_Context _erp_Context;
        public ProductProcessRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<ProductProcess> GetAllProductProccess()
        {
            var result = _erp_Context.ProductProcess.Include(x => x.Products).Include(x => x.Process).ThenInclude(x => x.ProcessLanguage).AsSplitQuery().AsNoTracking();
            return result;
        }
    }
}