using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class MaterialSupplierDTOValidators : AbstractValidator<MaterialSupplierDTO>
    {
        public MaterialSupplierDTOValidators()
        {
            RuleFor(x => x.CompanyId).NotEmpty().WithMessage("CompanyId (*)").NotNull().WithMessage("CompanyId (*)");
            RuleFor(x => x.MaterialId).NotEmpty().WithMessage("MaterialId (*)").NotNull().WithMessage("MaterialId (*)");
        }
    }
}
