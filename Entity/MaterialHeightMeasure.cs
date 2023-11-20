namespace Entity
{
    public class MaterialHeightMeasure : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? HeightMeasureId { get; set; }
        public HeightMeasure HeightMeasures { get; set; }
        public int MaterialsId { get; set; }
        
    }
}