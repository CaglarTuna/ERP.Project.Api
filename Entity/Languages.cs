using System.Collections.Generic;

namespace Entity
{
    public class Languages : Base
    {
        public string? Name { get; set; }
        public string? ShortCode { get; set; }
        public List<CategoriesLanguage> CategoriesLanguage { get; set; }
        public List<ProcessLanguage> ProcessLanguage { get; set; }
    }
}