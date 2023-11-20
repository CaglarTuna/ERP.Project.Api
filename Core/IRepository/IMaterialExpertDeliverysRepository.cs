using Entity;
using System.Collections.Generic;
using System.Linq;

namespace Core
{
    public interface IMaterialExpertDeliverysRepository : IRepository<MaterialExpertDeliverys>
    {
        IQueryable<MaterialExpertDeliverys> GetAllDeliverys();
    }
}
