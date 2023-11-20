using FluentValidation;

namespace DTO.DTOValidators
{
    public class ConsumptionMaterialStockDTOValidator : AbstractValidator<ConsumptionMaterialStockDTO>
    {
        public ConsumptionMaterialStockDTOValidator()
        {
            RuleFor(x => x.CreateDate).NotEmpty().WithMessage("CreateDate (*)").NotNull().WithMessage("CreateDate (*)");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate (*)").NotNull().WithMessage("UpdateDate (*)");
        }
    }
}