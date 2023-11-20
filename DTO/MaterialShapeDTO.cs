using System.Collections.Generic;

namespace DTO
{
    public class MaterialShapeDTO : BaseDTO
    {
        public string Name { get; set; }
        public List<MaterialDTO> MaterialDTOs { get; set; }
    }
}