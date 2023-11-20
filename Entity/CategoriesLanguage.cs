namespace Entity
{
    public class CategoriesLanguage : Base
    {
        public int? CategoriesId { get; set; }
        public Categories Categories { get; set; }
        public int? LanguageId { get; set; }
        public Languages Languages { get; set; }
        public string? Name { get; set; }
    }
}