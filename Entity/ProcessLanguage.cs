namespace Entity
{
    public class ProcessLanguage : Base
    {
        public int ProcessId { get; set; }
        public Process Process { get; set; }
        public string? Name { get; set; }
        public int LanguageId { get; set; }
        public Languages Languages { get; set; }
    }
}