using System.Collections.Generic;

namespace Entity
{
    public class MaterialSupplyRequests : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? OrderId { get; set; }
        public Orders Orders { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
        public int? RequestingStaffId { get; set; }
        public int? ApprovingStaffId { get; set; }
        public int? Quantity { get; set; }
        public int? RequestMadeQuantity { get; set; }
        
        public int? SuplyStatuId { get; set; }
        public MaterialSupplyStatu MaterialSupply { get; set; }
    }
}