using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OrderMaterialDTO : BaseDTO
    {
        public int OrderId { get; set; }
        public OrderDTO Orders { get; set; }
        public int MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int Quantitiy { get; set; }
    }
}
