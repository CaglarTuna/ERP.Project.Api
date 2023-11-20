using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class ProcessDTOValidator : AbstractValidator<ProcessDTO>
    {
        public ProcessDTOValidator()
        {
            RuleFor(c => c.CreateDate).NotEmpty().WithMessage("CreateDate NotEmpty").NotNull().WithMessage("CreateDate NotNull");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate NotEmpty").NotNull().WithMessage("UpdateDate NotNull");
            RuleFor(x => x.Cost).NotEmpty().WithMessage("Cost NotEmpty").NotNull().WithMessage("Cost NotNull");
            RuleFor(x => x.ProcessNo).NotEmpty().WithMessage("ProcessNo NotEmpty").NotNull().WithMessage("ProcessNo NotNull");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name NotEmpty").NotNull().WithMessage("Name NotNull");

        }
    }
}
