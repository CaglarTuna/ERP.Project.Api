using System.Collections.Generic;

namespace Entity
{
    public class Categories : Base
    {
        public int? TopCategoryId { get; set; }
        public List<CategoriesLanguage> CategoriesLanguage { get; set; }
        public List<Products> Products { get; set; }
    }
}