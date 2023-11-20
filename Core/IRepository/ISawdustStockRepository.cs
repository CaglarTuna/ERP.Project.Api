using Entity;
using System.Collections.Generic;

namespace Core
{
    public interface ISawdustStockRepository : IRepository<SawdustStock>
    {
        List<SawdustStock> sawdustStocks();
    }

}
