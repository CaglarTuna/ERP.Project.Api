namespace Entity
{
    public class MaterialRawMaterials : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? RawMaterialId { get; set; }
        public RawMaterials RawMaterials { get; set; }
    }
}