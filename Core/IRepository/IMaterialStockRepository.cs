using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public interface IMaterialStockRepository : IRepository<MaterialStock>
    {
        IQueryable<MaterialStock> GetAllStock();
    }
}
