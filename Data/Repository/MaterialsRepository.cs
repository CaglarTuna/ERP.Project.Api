using Core;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repository
{
    public class MaterialsRepository : Repository<Materials>, IMaterialsRepository
    {
        Erp_Context _erp_Context;
        public MaterialsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public List<Materials> GetAllMaterial()
        {
            var result = _erp_Context.Materials
                 .Include(x => x.MaterialUnitsOfMeasures)
                 .ThenInclude(x => x.UnitsOfMeasure)
                 .Include(x => x.MaterialRawMaterials)
                 .ThenInclude(x => x.RawMaterials)
                 .Include(x => x.MaterialSuppliers)
                 .ThenInclude(x => x.Companies)
                 .Include(x => x.Currencies)
                 .Include(x => x.MaterialShapes)
                 .Include(x => x.HeightMeasure)
                 .Include(x => x.MaterialHeightMeasures).ThenInclude(x => x.HeightMeasures)
                 .AsNoTracking().AsSplitQuery().ToList();
            return result;
        }

        public Materials getByMaterial(int id)
        {
            var result = _erp_Context.Materials
                  .Include(x => x.HeightMeasure)
                  .Include(x => x.MaterialUnitsOfMeasures)
                  .ThenInclude(x => x.UnitsOfMeasure)
                  .Include(x => x.MaterialRawMaterials)
                  .ThenInclude(x => x.RawMaterials)
                  .Include(x => x.MaterialSuppliers)
                  .ThenInclude(x => x.Companies)
                  .Include(x => x.MaterialHeightMeasures).ThenInclude(x => x.HeightMeasures)
                  .Include(x => x.Currencies).Include(x => x.MaterialShapes)
                  .AsNoTracking().AsSplitQuery().Where(x => x.Id == id).FirstOrDefault();
            return result;
        }

        public List<MaterialCertificates> GetByMaterialCettificate(int id)
        {
            var result = _erp_Context.MaterialCertificates.Include(x => x.Materials).Include(x => x.Companies).Where(x => x.CompanyId == id).AsNoTracking().ToList();
            return result;
        }

        public Materials GetByMaterialsDetail(int id)
        {
            var result = _erp_Context.Materials.Include(x => x.MaterialRawMaterials).Include(x => x.MaterialSuppliers).AsNoTracking().FirstOrDefault();
            return result;
        }
    }
}