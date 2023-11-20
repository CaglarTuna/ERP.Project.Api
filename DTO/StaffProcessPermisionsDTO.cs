using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class StaffProcessPermisionsDTO:BaseDTO
    {
        public int ProcessId { get; set; }
        public string Name { get; set; }
        public ProcessDTO ProcessDTO { get; set; }
    }
}
