using Core;
using Entity;

namespace Data.Repository
{
    public class CurrenciesRepository : Repository<Currencies>, ICurrenciesRepository
    {
        public CurrenciesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}