namespace DTO
{
    public class MaterialHeightMeasureDTO : BaseDTO
    {
        public int? MaterialId { get; set; }
        public MaterialDTO Materials { get; set; }
        public int? HeightMeasureId { get; set; }
        public HeightMeasureDTO HeightMeasures { get; set; }
    }
}
