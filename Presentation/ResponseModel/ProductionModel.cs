using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class ProductionModel
    {
        public List<OrderProductDTO> orderProducts { get; set; }
        public List<StaffDTO> staffs { get; set; }
        public List<ProductProcessDTO> productProcesses { get; set; }
    }
}
