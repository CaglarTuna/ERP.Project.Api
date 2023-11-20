using DTO;
using Entity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public interface IProductsRepository : IRepository<Products>
    {
        IQueryable<Products> GetAllProducts();
        Products GetProducts(int id);
        Task<List<Products>> getAllProductAsync();
        IQueryable<Products> GetCategoryByProducts(int id);
    }

}
