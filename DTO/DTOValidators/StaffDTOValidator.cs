using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class StaffDTOValidator : AbstractValidator<StaffDTO>
    {
        public StaffDTOValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email (*)").NotNull().WithMessage("Email (*)");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name (*)").NotNull().WithMessage("Name (*)");
            RuleFor(x => x.Surname).NotNull().WithMessage("Surname (*)").NotEmpty().WithMessage("Surname (*)");
            RuleFor(x => x.StaffRolesDTO.Count()).GreaterThan(0).When(x => x != null).WithMessage("Staff Roles(*)");
        }
    }
}
