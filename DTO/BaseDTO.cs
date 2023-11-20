using System;

namespace DTO
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; }
        public int Status { get; set; }
        public string StatuName { get; set; }
    }
}