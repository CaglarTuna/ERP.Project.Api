using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class CompanyAddressDTOValidator : AbstractValidator<CompanyAddressDTO>
    {
        public CompanyAddressDTOValidator()
        {
            RuleFor(c => c.CreateDate).NotEmpty().WithMessage("CreateDate NotEmpty").NotNull().WithMessage("CreateDate NotNull");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate NotEmpty").NotNull().WithMessage("UpdateDate NotNull");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Address NotEmpty").NotNull().WithMessage("Address NotNull");
            RuleFor(x => x.AddressTitle).NotEmpty().WithMessage("AddressTitle NotEmpty").NotNull().WithMessage("AddressTitle NotNull");
        }
    }
}
