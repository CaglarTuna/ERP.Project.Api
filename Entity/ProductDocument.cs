namespace Entity
{
    public class ProductDocument : Base
    {
        public int? ProductId { get; set; }
        public Products Products { get; set; }
        public int? DocumentId { get; set; }
        public Document Document { get; set; }
    }
}