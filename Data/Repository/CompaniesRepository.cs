using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repository
{
    public class CompaniesRepository : Repository<Companies>, ICompaniesRepository
    {
        Erp_Context _erp_Context;

        public CompaniesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<Companies> GetAllWithCompanyAddress()
        {
            return _erp_Context.Companies.Include(x => x.CompanyAddress).Where(x => x.Status != 3).AsNoTracking();
        }

        public Companies GetCompanyDetail(int id)
        {
            var result = _erp_Context.Companies.Include(x => x.CompanyAddress).Where(x=>x.Id==id).AsNoTracking().FirstOrDefault();
            return result;
        }

        public IQueryable<Companies> GetWithByIdCompanyAddress(int id)
        {
            return _erp_Context.Companies.Include(x => x.CompanyAddress).Where(x => x.Id == id && x.Status != 3).AsNoTracking();
        }
    }
}