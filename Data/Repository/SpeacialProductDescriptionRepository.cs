using Core;
using Entity;

namespace Data.Repository
{
    public class SpeacialProductDescriptionRepository : Repository<SpeacialProductDescription>, ISpeacialProductDescriptionRepository
    {
        public SpeacialProductDescriptionRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}