namespace Entity
{
    public class StaffProcess : Base
    {
        public int? StaffId { get; set; }
        public Staffs Staffs { get; set; }
        public int? ProductId { get; set; }
        public Products Products { get; set; }
        public int? ProcessId { get; set; }
        public Process Process { get; set; }
        public bool? SignatureStatu { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        public int? Second { get; set; }
        public int? OrderProductId { get; set; }
        public OrderProducts Orders { get; set; }
    }
}