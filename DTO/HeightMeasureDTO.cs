using System.Collections.Generic;

namespace DTO
{
    public class HeightMeasureDTO : BaseDTO
    {
        public string Name { get; set; }
        public List<MaterialHeightMeasureDTO> MaterialHeightMeasureDTOs { get; set; }
        public List<MaterialDTO> Materials { get; set; }
    }
}
