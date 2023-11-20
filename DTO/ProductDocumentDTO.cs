using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductDocumentDTO:BaseDTO
    {
        public int ProductId { get; set; }
        public ProductDTO Products { get; set; }
        public int DocumentId { get; set; }
        public DocumentDTO Document { get; set; }
    }
}
