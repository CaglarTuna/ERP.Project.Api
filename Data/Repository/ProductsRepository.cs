using Core;
using DTO;
using Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ProductsRepository : Repository<Products>, IProductsRepository
    {
        Erp_Context _erp_Context;
        public ProductsRepository(Erp_Context erp_Context) : base(erp_Context)
        {
            _erp_Context = erp_Context;
        }

        public async Task<List<Products>> getAllProductAsync()
        {
            var query = await _erp_Context.Products
                .Include(x => x.Categories)
                .ThenInclude(x => x.CategoriesLanguage).AsSplitQuery()
                .Include(x => x.ProductMaterials)
                .ThenInclude(x => x.Materials).AsSplitQuery()
                .Include(x => x.ProductProcess)
                .ThenInclude(x => x.Process)
                .ThenInclude(x => x.ProcessLanguage).AsSplitQuery()
                .Include(x => x.ProductDocuments)
                .ThenInclude(x => x.Document)
                .Include(x => x.ProductMaterials)
                .ThenInclude(x => x.HeightMeasures).AsSplitQuery()
                .AsNoTracking().ToListAsync();
            return query;
        }

        public IQueryable<Products> GetAllProducts()
        {

            var query = _erp_Context.Products
                .Include(x => x.Categories)
                .ThenInclude(x => x.CategoriesLanguage)
                .Include(x => x.ProductMaterials)
                .ThenInclude(x => x.Materials)
                .Include(x => x.ProductProcess)
                .ThenInclude(x => x.Process)
                .ThenInclude(x => x.ProcessLanguage)
                .Include(x => x.ProductDocuments)
                .ThenInclude(x => x.Document)
                .Include(x => x.ProductMaterials)
                .ThenInclude(x => x.HeightMeasures)
                .AsNoTracking().AsSplitQuery();
            return query;
        }
        public IQueryable<Products> GetCategoryByProducts(int id)
        {
            var query = _erp_Context.Products
                .Where(x => x.CategoryId == id)
                 .Include(x => x.Categories)
                 .ThenInclude(x => x.CategoriesLanguage)
                 .Include(x => x.ProductMaterials)
                 .ThenInclude(x => x.Materials)
                 .Include(x => x.ProductProcess)
                 .ThenInclude(x => x.Process)
                 .ThenInclude(x => x.ProcessLanguage)
                 .Include(x => x.ProductDocuments)
                 .ThenInclude(x => x.Document)
                 .Include(x => x.ProductMaterials)
                 .ThenInclude(x => x.HeightMeasures)
                 .AsNoTracking().AsSplitQuery();
            return query;
        }

        public Products GetProducts(int id)
        {
            var query = _erp_Context.Products
                .Where(x => x.Id == id)
                .Include(x => x.Categories)
                .ThenInclude(x => x.CategoriesLanguage)
                .Include(x => x.ProductProcess)
                .ThenInclude(x => x.Process)
                .ThenInclude(x => x.ProcessLanguage)
                .Include(x => x.ProductDocuments)
                .ThenInclude(x => x.Document)
                .Include(x => x.ProductMaterials)
                .ThenInclude(x => x.HeightMeasures)
                .Include(x => x.ProductMaterials)
                .ThenInclude(x => x.Materials)
                .AsNoTracking().FirstOrDefault();
            return query;
        }
    }
}