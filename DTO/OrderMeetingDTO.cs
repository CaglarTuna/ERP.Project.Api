using System;

namespace DTO
{
    public class OrderMeetingDTO : BaseDTO
    {
        public DateTime MeetingDate { get; set; }
        public string MeetingNote { get; set; }
        public DateTime ReminderDate { get; set; }
        public string ReminderNote { get; set; }
    }
}
