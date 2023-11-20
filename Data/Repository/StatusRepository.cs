using Core.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class StatusRepository:Repository<Status>,IStatusRepository
    {
        public StatusRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}
