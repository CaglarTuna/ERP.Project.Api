using System.Collections.Generic;

namespace Entity
{
    public class OrderChannel : Base
    {
        public string? Name { get; set; }
        public List<Orders> Orders { get; set; }
    }
}