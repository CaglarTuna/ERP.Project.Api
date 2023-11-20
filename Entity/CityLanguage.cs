namespace Entity
{
    public class CityLanguage:Base
    {
        public int? CityId { get; set; }
        public City Cities { get; set; }
        public string? Name { get; set; }
        public int? LanguageId { get; set; }
        public Languages Languages { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
    }
}