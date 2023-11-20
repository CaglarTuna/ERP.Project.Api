using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class MaterialSupplyRequestsRepository : Repository<MaterialSupplyRequests>, IMaterialSupplyRequestsRepository
    {
        Erp_Context _erp_Context;
        public MaterialSupplyRequestsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;

        }

        public List<MaterialSupplyRequests> GetMaterialSupplyRequest()
        {
            var result = _erp_Context.MaterialSupplyRequests
                .Include(x => x.Orders)
                .Include(x => x.Materials)
                .Include(x => x.Companies)
                .Include(x => x.MaterialSupply).AsNoTracking().AsSplitQuery().ToList();
            return result;
        }
    }
}