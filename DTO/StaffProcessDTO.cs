using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffProcessDTO : BaseDTO
    {
        public int StaffId { get; set; }
        public StaffDTO StaffDTO { get; set; }
        public int ProductId { get; set; }
        public ProductDTO ProductDTO { get; set; }
        public int ProcessId { get; set; }
        public ProcessDTO ProcessDTO { get; set; }
        public bool? SignatureStatu { get; set; }
        public int? OrderProductId { get; set; }
        public OrderProductDTO Orders { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        public int? Second { get; set; }
    }
}
