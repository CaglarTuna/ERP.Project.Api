using Core;
using Entity;
using System.Linq;
using Microsoft.EntityFrameworkCore;


namespace Data.Repository
{
    public class ProcessRepository : Repository<Process>, IProcessRepository
    {
        Erp_Context _erp_Context;

        public ProcessRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<Process> GetAllWithProcessLanguage(int languageId)
        {
            return _erp_Context.Process.Include(x=>x.Currencies).Include(x => x.ProcessLanguage).Where(x => x.ProcessLanguage.Where(x => x.LanguageId == languageId).Any() && x.Status == 1).AsNoTracking();
        }

        public IQueryable<Process> GetWithByIdProcessLanguage(int languageId, int id)
        {
            return _erp_Context.Process.Include(x => x.Currencies).Include(x => x.ProcessLanguage).Where(x => x.ProcessLanguage.Where(x => x.LanguageId == languageId).Any() && x.Id == id && x.Status == 1).AsNoTracking();
        }
    }
}