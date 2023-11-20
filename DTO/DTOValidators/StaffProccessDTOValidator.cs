using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class StaffProccessDTOValidator:AbstractValidator<StaffProcessDTO>
    {
        public StaffProccessDTOValidator()
        {
            RuleFor(x => x.ProcessId).NotNull().WithMessage("Proccess Id (*)").NotEmpty().WithMessage("Proccess Id (*)");
            RuleFor(x => x.ProductId).NotNull().WithMessage("Product Id (*)").NotEmpty().WithMessage("Product Id (*)");
            RuleFor(x => x.StaffId).NotNull().WithMessage("Staff Id (*)").NotEmpty().WithMessage("Staff Id (*)");
        }
    }
}
