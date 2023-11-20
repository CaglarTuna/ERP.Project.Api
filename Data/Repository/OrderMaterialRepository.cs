using Core.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class OrderMaterialRepository:Repository<OrderMaterial>,IOrderMaterialRepository
    {
        Erp_Context _erp_Context;
        public OrderMaterialRepository(Erp_Context erp_Context):base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}
