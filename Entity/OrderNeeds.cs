namespace Entity
{
    public class OrderNeeds : Base
    {
        public string OrderNo { get; set; }
        public int? OrderId { get; set; }
        public Orders Orders { get; set; }
        public int? ProductId { get; set; }
        public Products Products { get; set; }
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? Recruitment { get; set; }
        public int? Quantity { get; set; }
    }
}
