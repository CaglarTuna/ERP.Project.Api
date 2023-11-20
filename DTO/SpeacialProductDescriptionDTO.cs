using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SpeacialProductDescriptionDTO : BaseDTO
    {
        public string? Name { get; set; }
        public int? Quantitiy { get; set; }
        public string? SpecialProductDescription { get; set; }
    }
}
