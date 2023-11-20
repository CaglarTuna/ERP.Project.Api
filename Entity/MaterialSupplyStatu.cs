using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class MaterialSupplyStatu : Base
    {
        public string Name { get; set; }
        public List<MaterialSupplyRequests> MaterialSupplyRequests { get; set; }
    }
}
