using Entity;
using System.Collections.Generic;

namespace Core
{
    public interface IMaterialSupplyRequestsRepository : IRepository<MaterialSupplyRequests>
    {
        List<MaterialSupplyRequests> GetMaterialSupplyRequest();
    }
}
