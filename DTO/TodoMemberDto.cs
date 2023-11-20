using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TodoMemberDto:BaseDTO
    {
        public int? StaffId { get; set; }
        public StaffDTO Staffs { get; set; }
        public int? TodoId { get; set; }
        public TodoDto TodoList { get; set; }
        public bool FlagMember { get; set; }
    }
}
