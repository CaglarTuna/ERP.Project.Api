using FluentValidation;

namespace DTO.DTOValidators
{
    public class CompanyDTOValidator : AbstractValidator<CompanyDTO>
    {
        public CompanyDTOValidator()
        {
            RuleFor(c => c.CreateDate).NotEmpty().WithMessage("CreateDate NotEmpty").NotNull().WithMessage("CreateDate NotNull");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate NotEmpty").NotNull().WithMessage("UpdateDate NotNull");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name NotEmpty").NotNull().WithMessage("Name NotNull");
            RuleFor(x => x.TaxNumber).NotEmpty().WithMessage("TaxNumber NotEmpty").NotNull().WithMessage("TaxNumber NotNull");
            RuleFor(x => x.TaxOffice).NotEmpty().WithMessage("TaxOffice NotEmpty").NotNull().WithMessage("TaxOffice NotNull");
            RuleFor(x => x.Department).NotEmpty().WithMessage("Department NotEmpty").NotNull().WithMessage("Department NotNull");
            RuleFor(x => x.ContactPerson).NotEmpty().WithMessage("ContactPerson NotEmpty").NotNull().WithMessage("ContactPerson NotNull");
            RuleFor(x => x.Telephone).NotEmpty().WithMessage("Telephone NotEmpty").NotNull().WithMessage("Telephone NotNull");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email NotEmpty").NotNull().WithMessage("Email NotNull");
            RuleFor(x => x.Prefix).NotEmpty().WithMessage("Prefix NotEmpty").NotNull().WithMessage("Prefix NotNull");
        }
    }
}