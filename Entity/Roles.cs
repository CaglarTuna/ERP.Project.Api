using System.Collections.Generic;

namespace Entity
{
    public class Roles : Base
    {
        public string? Name { get; set; }
        public List<StaffRoles> StaffRoles { get; set; }
    }
}