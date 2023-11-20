using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class StaffProccessPermisionsDtoValidator : AbstractValidator<StaffProcessPermisionsDTO>
    {
        public StaffProccessPermisionsDtoValidator()
        {
            RuleFor(x => x.CreateDate).NotNull();
            RuleFor(x => x.UpdateDate).NotNull();
            RuleFor(x => x.ProcessId).NotNull().WithMessage("ProcessId (*)").NotEmpty().WithMessage("ProcessId (*)");
        }
    }
}
