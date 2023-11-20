using System.Collections.Generic;

namespace Entity
{
    public class RawMaterials : Base
    {
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Density { get; set; }
        public List<MaterialRawMaterials> MaterialRawMaterials { get; set; }
    }
}