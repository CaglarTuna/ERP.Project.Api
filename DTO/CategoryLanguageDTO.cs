using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoryLanguageDTO : BaseDTO
    {
        public string Name { get; set; }
        public int CategoriesId { get; set; }
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
    }
}
