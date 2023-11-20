using System.Collections.Generic;

namespace Entity
{
    public class Staffs : Base
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public string? Department { get; set; }
        public string? Address { get; set; }
        public string? StaffNo { get; set; }
        public List<ConsumptionMaterialStock> ConsumptionMaterialStock { get; set; }
        public List<StaffProcess> StaffProcess { get; set; }
        public List<StaffProcessPermisions> StaffProcessPermisions { get; set; }
        public List<StaffRoles> StaffRoles { get; set; }
        public List<TodoList> TodoLists { get; set; }
        public List<MaterialExpertDeliverys> MaterialExpertDeliverys { get; set; }
        public List<Orders> Orders { get; set; }
        public List<TodoMember> TodoMembers { get; set; }
    }
}