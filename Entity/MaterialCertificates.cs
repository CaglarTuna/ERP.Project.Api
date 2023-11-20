namespace Entity
{
    public class MaterialCertificates : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public string? Certificate { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
    }
}