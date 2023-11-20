using Entity;
using System.Linq;

namespace Core
{
    public interface IRawMaterialsRepository : IRepository<RawMaterials>
    {
        IQueryable<RawMaterials> GetAllWithRawMaterial();
        IQueryable<RawMaterials> GetWithByIdRawMaterial(int id);
    }
}
