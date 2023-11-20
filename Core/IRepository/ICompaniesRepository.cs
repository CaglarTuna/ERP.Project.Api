using Entity;
using System.Linq;

namespace Core
{
    public interface ICompaniesRepository : IRepository<Companies>
    {
        IQueryable<Companies> GetAllWithCompanyAddress();
        IQueryable<Companies> GetWithByIdCompanyAddress(int id);
        Companies GetCompanyDetail(int id);
    }
}
