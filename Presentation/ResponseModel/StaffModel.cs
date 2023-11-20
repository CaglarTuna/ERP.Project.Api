using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.ResponseModel
{
    public class StaffModel:DataDto<StaffModel>
    {
        public StaffDTO staff { get; set; }
        public List<StaffDTO> StaffList { get; set; }
        public List<RolesDTO> roles { get; set; }


    }
}
