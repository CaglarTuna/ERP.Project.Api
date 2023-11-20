using System.Collections.Generic;

namespace Entity
{
    public class Document : Base
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Path { get; set; }
        public string? UrlPath { get; set; }
        public List<ProductDocument> ProductDocuments { get; set; }
    }
}