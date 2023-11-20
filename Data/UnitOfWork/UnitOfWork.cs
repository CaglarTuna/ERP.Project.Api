using Core;
using Core.IUnitOfWork;
using Data.Repository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Erp_Context _erp_Context;
        public UnitOfWork(Erp_Context erp_Context)
        {

            _erp_Context = erp_Context;
        }
        public void Dispose()
        {
            _erp_Context.Dispose();
        }

        public int SaveChanges()
        {
            return _erp_Context.SaveChanges();
        }
    }
}
