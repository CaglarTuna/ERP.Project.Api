using FluentValidation;

namespace DTO.DTOValidators
{
    public class RawMaterialDTOValidator : AbstractValidator<RawMaterialDTO>
    {
        public RawMaterialDTOValidator()
        {
            RuleFor(x => x.CreateDate).NotEmpty().WithMessage("CreateDate NotEmpty").NotNull().WithMessage("CreateDate NotNull");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate NotEmpty").NotNull().WithMessage("UpdateDate NotNull");
            RuleFor(x => x.Code).NotEmpty().WithMessage("Code NotEmpty").NotNull().WithMessage("Code NotNull").MaximumLength(10).WithMessage("maximum length must be 10 characters");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name NotEmpty").NotNull().WithMessage("Name NotNull");
            RuleFor(x => x.Density).NotEmpty().WithMessage("Density NotEmpty").NotNull().WithMessage("Density NotNull").MaximumLength(50).WithMessage("maximum length must be 50 characters"); ;
        }
    }
}
