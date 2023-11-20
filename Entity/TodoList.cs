using System.Collections.Generic;
namespace Entity
{
    public class TodoList : Base
    {
        public string? Description { get; set; }
        public int? InterestId { get; set; }
        public Orders Orders { get; set; }
        public bool Flag { get; set; }
        public List<TodoMember> TodoMembers { get; set; }
       
    }
}