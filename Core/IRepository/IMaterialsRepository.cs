using Entity;
using System.Collections.Generic;

namespace Core
{
    public interface IMaterialsRepository : IRepository<Materials>
    {
        Materials GetByMaterialsDetail(int id);
        List<MaterialCertificates> GetByMaterialCettificate(int id);
        List<Materials> GetAllMaterial();
        Materials getByMaterial(int id);

    }
}
