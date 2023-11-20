using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class MaterialStockEntyrModel
    {
        public List<StoreDTO> Stores { get; set; }
        public List<MaterialDTO> Materials { get; set; }
        public List<CompanyDTO> Companies { get; set; }
        public List<OrderDTO> Orders { get; set; }
        public List<MaterialStockDTO> MaterialStocks { get; set; }
    }
}
