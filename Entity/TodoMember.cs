using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class TodoMember : Base
    {
        public int? StaffId { get; set; }
        public Staffs Staffs { get; set; }
        public int? TodoId { get; set; }
        public TodoList TodoList { get; set; }
        public bool FlagMember { get; set; }

    }
}
