namespace Entity
{
    public class StaffProcessPermisions : Base
    {
        public int? StaffId { get; set; }
        public Staffs Staffs { get; set; }
        public int? ProcessId { get; set; }
        public Process Process { get; set; }
    }
}