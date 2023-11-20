using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StandProccessDTO : BaseDTO
    {
        public int StandId { get; set; }
        public StandDTO Stands { get; set; }
        public int ProcessId { get; set; }
        public ProcessDTO Process { get; set; }
        
    }
}
