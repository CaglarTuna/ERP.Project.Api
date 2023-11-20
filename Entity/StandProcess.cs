namespace Entity
{
    public class StandProcess : Base
    {
        public int? StandId { get; set; }
        public Stands Stands { get; set; }
        public int? ProcessId { get; set; }
        public Process Process { get; set; }
    }
}