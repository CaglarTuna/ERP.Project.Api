using Core;
using DTO;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class CategoriesRepository : Repository<Categories>, ICategoriesRepository
    {
        Erp_Context _erp_Context;
        public CategoriesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<Categories> GetAllWithCategroyLanguage(int languageId, int topcategoryId)
        {
            return _erp_Context.Categories.Include(x => x.CategoriesLanguage).Where(x => x.CategoriesLanguage.Where(x => x.LanguageId == languageId).Any() && x.TopCategoryId == topcategoryId && x.Status == 1).AsNoTracking();
        }

        public IQueryable<Categories> GetWithByIdCategroyLanguage(int languageId, int id)
        {
            return _erp_Context.Categories.Include(x => x.CategoriesLanguage).Where(x => x.CategoriesLanguage.Where(x => x.LanguageId == languageId).Any() && x.Id == id && x.Status == 1).AsNoTracking();
        }
    }
}
