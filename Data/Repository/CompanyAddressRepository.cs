using Core;
using Entity;

namespace Data.Repository
{
    public class CompanyAddressRepository : Repository<CompanyAddress>, ICompanyAddressRepository
    {
        public CompanyAddressRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}