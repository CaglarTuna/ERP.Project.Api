using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DocumentDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Path { get; set; }
        public string UrlPath { get; set; }
        public List<ProductDocumentDTO> ProductDocuments { get; set; }
    }
}
