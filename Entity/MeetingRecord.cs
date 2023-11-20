using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity
{
    public class MeetingRecord : Base
    {
        public DateTime? MeetingDate { get; set; }
        public string? MeetingNote { get; set; }
        public DateTime? ReminderDate { get; set; }
        public string? ReminderNote { get; set; }
        public int? OrderId { get; set; }
        public Orders Orders { get; set; }
    }
}