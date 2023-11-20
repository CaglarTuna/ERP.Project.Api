using Core.IServices;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.IServices
{
    public interface IMaterialSupplyRequestsService : IService<MaterialSupplyRequestsDTO>
    {
        void materialSuppliesListAdd(List<MaterialSupplyRequestsDTO> materials);
        void materialSupplyRequestReply(List<MaterialSupplyRequestsDTO> materials);
    }
}
