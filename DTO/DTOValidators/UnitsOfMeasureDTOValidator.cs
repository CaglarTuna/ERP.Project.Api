using FluentValidation;

namespace DTO.DTOValidators
{
    public class UnitsOfMeasureDTOValidator : AbstractValidator<UnitsOfMeasureDTO>
    {
        public UnitsOfMeasureDTOValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name NotEmpty").NotNull().WithMessage("Name NotNull");
        }
    }
}