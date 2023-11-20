using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class ConsuptionMaterialResponseModel
    {
        public ConsumptionMaterialDTO consumptionMaterial { get; set; }
        public List<ConsumptionMaterialDTO> consumptionMaterialDTOs { get; set; }
        public List<CommonDTO> commonDTOs { get; set; }
        public List<CompanyDTO> companies { get; set; }
        public List<ConsumptionMaterialStockDTO> consumptionMaterialStocks { get; set; }
        public ConsumptionMaterialStockDTO ConsumptionMaterialStockDTO { get; set; }
        public List<StoreDTO> store { get; set; }
        public List<StaffDTO> staffDTOs { get; set; }
        public StaffDTO StaffDTO { get; set; }
        public List<StandDTO> standDTOs { get; set; }
        public List<OrderDTO> orderDTOs { get; set; }
    }
}
