using System;
using System.ComponentModel.DataAnnotations;

namespace Entity
{
    public class Base
    {
        //[Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }
    }
}
