using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FilterDto
    {
        public DateTime FirstDate { get; set; }
        public DateTime LastDate { get; set; }
        public string Filter { get; set; }
    }
}
