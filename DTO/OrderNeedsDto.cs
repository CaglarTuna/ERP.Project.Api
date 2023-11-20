using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderNeedsDto : BaseDTO
    {
        public string OrderNo { get; set; }
        public int? OrderId { get; set; }
        public OrderDTO Orders { get; set; }
        public int? ProductId { get; set; }
        public ProductDTO Products { get; set; }
        public int? MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int? Recruitment { get; set; }
        public float Quantity { get; set; }
        public int ShortBy { get; set; }
    }
}
