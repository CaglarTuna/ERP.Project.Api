using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductProcessDTO:BaseDTO
    {
        public int ProductId { get; set; }
        public ProductDTO Products { get; set; }
        public int ProcessId { get; set; }
        public ProcessDTO Process { get; set; }
        public int ProcessDuration { get; set; }
        public int ProcessOrderNo { get; set; }
    }
}
