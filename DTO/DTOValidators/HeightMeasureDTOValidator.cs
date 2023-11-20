using FluentValidation;

namespace DTO.DTOValidators
{
    public class HeightMeasureDTOValidator : AbstractValidator<HeightMeasureDTO>
    {
        public HeightMeasureDTOValidator()
        {
            RuleFor(x => x.CreateDate).NotEmpty().WithMessage("CreateDate (*)").NotNull().WithMessage("CreateDate (*)");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate (*)").NotNull().WithMessage("UpdateDate (*)");
        }
    }
}
