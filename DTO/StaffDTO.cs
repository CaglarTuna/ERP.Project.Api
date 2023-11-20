using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace DTO
{
    public class StaffDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Department { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string StaffNo { get; set; }
        public List<RolesSelectList> RoleNames { get; set; }
        public List<SelectListItem> ProccessName { get; set; }
      
        public int StaffId { get; set; }
        public int RoleId { get; set; }
        public int ProcessId { get; set; }
        public string Token { get; set; }
        public List<StaffProcessPermisionsDTO> StaffProcessPermisionsDTOs { get; set; }
        public List<StaffRolesDTO> StaffRolesDTO { get; set; }
        public List<OrderDTO> Orders { get; set; }
        public string RoleName { get; set; }
    }
    public class RolesSelectList
    {
        public string Name { get; set; }
        public string Value { get; set; }

    }
}
