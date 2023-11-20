using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class CategoryDTOValidator: AbstractValidator<CategoryDTO>
    {
        public CategoryDTOValidator()
        {
            RuleFor(c => c.CreateDate).NotEmpty().WithMessage("CreateDate (*)").NotNull().WithMessage("CreateDate (*)");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate (*)").NotNull().WithMessage("UpdateDate (*)");
            RuleFor(x => x.CategoryLanguageDTO.Name).NotEmpty().WithMessage("CategoryLanguageDTO.Name (*)").NotNull().WithMessage("CategoryLanguageDTO.Name (*)");
            RuleFor(x => x.CategoryLanguageDTO.LanguageId).NotEmpty().WithMessage("CategoryLanguageDTO.LanguageId (*)").NotNull().WithMessage("CategoryLanguageDTO.LanguageId (*)");
        }
    }
}
