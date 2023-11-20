namespace Entity
{
    public class ProductProcess : Base
    {
        public int? ProductId { get; set; }
        public Products Products { get; set; }
        public int? ProcessId { get; set; }
        public Process Process { get; set; }
        public int? ProcessDuration { get; set; }
        public int? ProcessOrderNo { get; set; }
    }
}