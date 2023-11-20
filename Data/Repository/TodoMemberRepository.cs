using Core.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class TodoMemberRepository : Repository<TodoMember>, ITodoMemberRepository
    {
        Erp_Context _erp_Context;
        public TodoMemberRepository(Erp_Context erp_Context):base(erp_Context)
        {
            _erp_Context = erp_Context;
        }
    }
}
