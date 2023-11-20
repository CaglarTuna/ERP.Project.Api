namespace Entity
{
    public class StaffRoles : Base
    {
        public int? StaffId { get; set; }
        public Staffs Staffs { get; set; }
        public int? RoleId { get; set; }
        public Roles Roles { get; set; }
    }
}