using Entity;
using System.Linq;

namespace Core
{
    public interface IProcessRepository : IRepository<Process>
    {
        IQueryable<Process> GetAllWithProcessLanguage(int languageId);
        IQueryable<Process> GetWithByIdProcessLanguage(int languageId, int id);

    }

}
