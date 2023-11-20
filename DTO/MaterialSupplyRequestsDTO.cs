using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MaterialSupplyRequestsDTO:BaseDTO
    {
        public int MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int OrderId { get; set; }
        public OrderDTO Orders { get; set; }
        public int? CompanyId { get; set; }
        public CompanyDTO Companies { get; set; }
        public int RequestingStaffId { get; set; }
        public int ApprovingStaffId { get; set; }
        public int Quantity { get; set; }
        public int RequestMadeQuantity { get; set; }
        public bool IsChecked { get; set; }
        public int? SuplyStatuId { get; set; }
        public MaterialSupplyStatuDTO MaterialSupplyStatu { get; set; }
    }
}
