using Core;
using Entity;

namespace Data.Repository
{
    public class LanguagesRepository : Repository<Languages>, ILanguagesRepository
    {
        public LanguagesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}