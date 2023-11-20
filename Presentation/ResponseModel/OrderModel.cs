using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class OrderModel : DataDto<OrderModel>
    {
        public List<OrderChannelDTO> OrderChannelDTOs { get; set; }
        public List<StoreDTO> StoreDTOs { get; set; }
        public List<CompanyDTO> companyDTOs { get; set; }
        public List<ProductDTO> productDTOs { get; set; }
    }
}
