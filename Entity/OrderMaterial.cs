using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class OrderMaterial : Base
    {
        public int OrderId { get; set; }
        public Orders Orders { get; set; }
        public int MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int Quantitiy { get; set; }
    }
}
