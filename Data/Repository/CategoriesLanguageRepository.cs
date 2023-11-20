using Core;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class CategoriesLanguageRepository : Repository<CategoriesLanguage>, ICategoriesLanguageRepository
    {
        public CategoriesLanguageRepository(Erp_Context erp_Context) : base(erp_Context)
        {

        }
    }
}
