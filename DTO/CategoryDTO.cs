using System.Collections.Generic;

namespace DTO
{
    public class CategoryDTO : BaseDTO
    {
         public int ProductLanguageCategoriesId { get; set; }
        public int CategoriesId { get; set; }
        public int TopCategoryId { get; set; }
        public string Name { get; set; }
        public CategoryLanguageDTO CategoryLanguageDTO { get; set; }
        public List<CategoryLanguageDTO> CategoryLanguageDTOs { get; set; }
        public List<CategoryDTO> SubCategoryDto { get; set; }
    }
}