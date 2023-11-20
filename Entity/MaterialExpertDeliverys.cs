namespace Entity
{
    public class MaterialExpertDeliverys : Base
    {
        public int? MaterialId { get; set; }
        public Materials Materials { get; set; }
        public int? Quantity { get; set; }
        public int? DeliveryStaffId { get; set; }
        public string? DeliveryNote { get; set; }
        public int? StaffId { get; set; }
        public Staffs Staffs { get; set; }
        public int? OrderId { get; set; }
        public Orders Orders { get; set; }
    }
}