using FluentValidation;

namespace DTO.DTOValidators
{
    public class MaterialDTOValidator:AbstractValidator<MaterialDTO>
    {
        public MaterialDTOValidator()
        {
            RuleFor(x => x.CreateDate).NotEmpty().WithMessage("CreateDate (*)").NotNull().WithMessage("CreateDate (*)");
            RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate (*)").NotNull().WithMessage("UpdateDate (*)");
            RuleFor(x => x.BarcodeNo).NotEmpty().WithMessage("BarcodeNo (*)").NotNull().WithMessage("BarcodeNo (*)");
            RuleFor(x => x.CurrencyId).NotEmpty().WithMessage("CurrencyId (*)").NotNull().WithMessage("CurrencyId (*)");
        }
    }
}