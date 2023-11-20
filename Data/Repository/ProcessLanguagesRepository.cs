using Core;
using Entity;

namespace Data.Repository
{
    public class ProcessLanguagesRepository : Repository<ProcessLanguage>, IProcessLanguageRepository
    {
        public ProcessLanguagesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}