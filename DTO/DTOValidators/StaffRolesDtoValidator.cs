using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class StaffRolesDtoValidator: AbstractValidator<StaffRolesDTO>
    {
        public StaffRolesDtoValidator()
        {
            RuleFor(x => x.CreateDate).NotNull();
            RuleFor(x => x.UpdateDate).NotNull();
            RuleFor(x => x.RoleId).NotNull().WithMessage("RoleId (*)").NotEmpty().WithMessage("RoleId (*)");
        }
    }
}
