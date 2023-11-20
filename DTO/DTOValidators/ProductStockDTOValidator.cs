using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class ProductStockDTOValidator:AbstractValidator<ProductStockDTO>
    {
        public ProductStockDTOValidator()
        {
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId (*)").NotNull().WithMessage("ProductId (*)");
            RuleFor(x => x.StoreId).NotNull().WithMessage("StoreId (*)").NotEmpty().WithMessage("StoreId (*)");
        }
    }
}
