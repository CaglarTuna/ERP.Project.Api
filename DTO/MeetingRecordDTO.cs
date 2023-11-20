using System;

namespace DTO
{
    public class MeetingRecordDTO : BaseDTO
    {
        public DateTime? MeetingDate { get; set; }
        public string? MeetingNote { get; set; }
        public DateTime? ReminderDate { get; set; }
        public string? ReminderNote { get; set; }
        public int? OrderId { get; set; }
        public OrderDTO Orders { get; set; }
    }
}
