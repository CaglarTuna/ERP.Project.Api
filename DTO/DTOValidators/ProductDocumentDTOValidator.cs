using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.DTOValidators
{
    public class ProductDocumentDTOValidator:AbstractValidator<ProductDocumentDTO>
    {
        public ProductDocumentDTOValidator()
        {
            RuleFor(x => x.DocumentId).NotNull().WithMessage("DocumentId (*)").NotEmpty().WithMessage("DocumentId (*)");
        }
    }
}
