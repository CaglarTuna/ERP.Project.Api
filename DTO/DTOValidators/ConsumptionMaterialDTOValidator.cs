using FluentValidation;

namespace DTO.DTOValidators
{
    public class ConsumptionMaterialDTOValidator : AbstractValidator<ConsumptionMaterialDTO>
    {
        public ConsumptionMaterialDTOValidator()
        {
            RuleFor(x => x.CreateDate).NotEmpty().WithMessage("CreateDate (*)").NotNull().WithMessage("CreateDate (*)");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate (*)").NotNull().WithMessage("UpdateDate (*)");
            RuleFor(x => x.Code).NotEmpty().WithMessage("Code (*)").NotNull().WithMessage("Code (*)");
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.CostPrice).NotEmpty();
            RuleFor(x => x.ConsumptionMaterialSuppliers.Count).GreaterThan(0).When(x => x != null).WithMessage("ConsumptionMaterialSuppliers (*)");
        }
    }
}