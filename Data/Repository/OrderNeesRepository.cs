using Core.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class OrderNeesRepository:Repository<OrderNeeds>, IOrderNeedsRepository
    {
        Erp_Context _erp_Contex;
        public OrderNeesRepository(Erp_Context erp_Contex):base(erp_Contex)
        {
            _erp_Contex = erp_Contex;
        }
    }
}
