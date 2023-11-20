using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StaffRolesDTO : BaseDTO
    {
        public int StaffId { get; set; }
        public StaffDTO Staffs { get; set; }
        public int RoleId { get; set; }
        public RolesDTO Roles { get; set; }
    }
}
