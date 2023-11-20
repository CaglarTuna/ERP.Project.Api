using Core.IRepository;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class DocumentRepository:Repository<Document>,IDocumentRepository
    {
        Erp_Context _erp_Context;

        public DocumentRepository(Erp_Context erp_Context):base(erp_Context)
        {
        }
    }
}
