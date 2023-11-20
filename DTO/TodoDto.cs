using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TodoDto:BaseDTO
    {
        public string? Description { get; set; }
        public int? InterestId { get; set; }
        public OrderDTO Orders { get; set; }
        public bool Flag { get; set; }
        public List<TodoMemberDto> TodoMembers { get; set; }
       
    }
}
