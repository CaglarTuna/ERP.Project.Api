using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Repository
{
    public class RawMaterialsRepository : Repository<RawMaterials>, IRawMaterialsRepository
    {
        Erp_Context _erp_Context;

        public RawMaterialsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public IQueryable<RawMaterials> GetAllWithRawMaterial()
        {
            return _erp_Context.RawMaterials.AsNoTracking
                ();
        }

        public IQueryable<RawMaterials> GetWithByIdRawMaterial(int id)
        {
            return _erp_Context.RawMaterials.Include(x => x.Id == id).AsNoTracking();
        }
    }
}