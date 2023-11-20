using Entity;
using System.Linq;

namespace Core
{
    public interface IProductProcessRepository : IRepository<ProductProcess>
    {
        IQueryable<ProductProcess> GetAllProductProccess();
    }

}
