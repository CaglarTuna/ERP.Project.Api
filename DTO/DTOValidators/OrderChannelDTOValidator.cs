using FluentValidation;

namespace DTO.DTOValidators
{
    public class OrderChannelDTOValidator : AbstractValidator<OrderChannelDTO>
    {
        public OrderChannelDTOValidator()
        {
            //RuleFor(x => x.CreateDate).NotEmpty().WithMessage("CreateDate (*)").NotNull().WithMessage("CreateDate (*)");
            //RuleFor(x => x.UpdateDate).NotEmpty().WithMessage("UpdateDate (*)").NotNull().WithMessage("UpdateDate (*)");
        }
    }
}
