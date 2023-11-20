using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class SawdustStockDTOValidator : AbstractValidator<SawdustStockDTO>
    {
        public SawdustStockDTOValidator()
        {
            RuleFor(x => x.CompanyId).NotNull().WithMessage("CompanyId (*)").NotEmpty().WithMessage("CompanyId (*)");
            RuleFor(x => x.InvoiceNo).NotEmpty().WithMessage("InvoiceNo (*)").NotNull().WithMessage("InvoiceNo (*)");
            RuleFor(x => x.MaterialId).NotNull().WithMessage("MaterialId (*)").NotEmpty().WithMessage("MaterialId (*)");
            //RuleFor(x => x.OrderId).NotEmpty().WithMessage("OrderId (*)").NotNull().WithMessage("OrderId (*)");
        }
    }
}
