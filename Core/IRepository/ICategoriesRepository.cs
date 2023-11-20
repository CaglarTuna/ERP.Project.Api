using DTO;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface ICategoriesRepository : IRepository<Categories>
    {
        IQueryable<Categories> GetAllWithCategroyLanguage(int languageId,int topcategoryId);
        IQueryable<Categories> GetWithByIdCategroyLanguage(int languageId, int id);
    }
}
