using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Status : Base
    {
        public string Name { get; set; }
        public List<Offers> Offers { get; set; }
        public List<Orders> Orders { get; set; }
        public List<OrderProducts> OrderProducts { get; set; }
        public List<ProductMaterials> ProductMaterials { get; set; }
    }
}
