using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repository
{
    public class StaffProcessRepository : Repository<StaffProcess>, IStaffProcessRepository
    {
        Erp_Context _erp_Context;
        public StaffProcessRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<StaffProcess> GetByIdStaffProccess(int id)
        {
            var result = _erp_Context.StaffProcess
                 .Include(x => x.Process)
                 .ThenInclude(x => x.ProcessLanguage)
                 .Include(x => x.Staffs)
                 .Include(x => x.Orders)
                 .Include(x => x.Products)
                 .Where(x => x.StaffId == id).AsNoTracking().AsSplitQuery();
            return result;
        }

        public IQueryable<StaffProcess> GetByStaffProccess(int ProductId, int OrderProductId)
        {
            var result = _erp_Context.StaffProcess
                .Include(x => x.Process)
                .ThenInclude(x=>x.ProcessLanguage)
                .Include(x => x.Staffs)
                .Include(x => x.Orders)
                .Include(x => x.Products)
                .Where(x => x.ProductId == ProductId && x.OrderProductId == OrderProductId).AsNoTracking().AsSplitQuery();
            return result;
        }
    }
}