using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RawMaterialDTO : BaseDTO
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Density { get; set; }
    }
}
