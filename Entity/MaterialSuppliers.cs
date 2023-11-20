namespace Entity
{
    public class MaterialSuppliers : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
    }
}