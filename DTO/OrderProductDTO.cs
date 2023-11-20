using System.Collections.Generic;

namespace DTO
{
    public class OrderProductDTO : BaseDTO
    {
        public int? OrderId { get; set; }
        public OrderDTO Orders { get; set; }
        public int? ProductId { get; set; }
        public ProductDTO Products { get; set; }
        public int? Quantitiy { get; set; }
        public int? RealizedProduction { get; set; }
        public int? StatusId { get; set; }
        public StatusDTO Statuss { get; set; }
        public List<StaffProcessDTO> StaffProcesses { get; set; }
    }

}
