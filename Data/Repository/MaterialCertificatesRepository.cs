using Core;
using Entity;

namespace Data.Repository
{
    public class MaterialCertificatesRepository : Repository<MaterialCertificates>, IMaterialCertificatesRepository
    {
        public MaterialCertificatesRepository(Erp_Context erp_Context) : base(erp_Context)
        {
        }
    }
}