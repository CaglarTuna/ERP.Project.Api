using System;
using System.Collections.Generic;

namespace Entity
{
    public class Products : Base
    {
        public int? CategoryId { get; set; }
        public Categories Categories { get; set; }
        public string? Name { get; set; }
        public string? ProductDescription { get; set; }
        public string? TechnicalImage { get; set; }
        public bool? IsPrescriptions { get; set; }
        public string? ProductCost { get; set; }
        public string? ProductCertificate { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? InvoiceNo { get; set; }
        public string? BarcodeNo { get; set; }
        public string? ProductionSerialNumber { get; set; }
        public int? ProductType { get; set; }
        public int? Hour { get; set; }
        public int? Minute { get; set; }
        public int? Second { get; set; }
        public List<ProductMaterials> ProductMaterials { get; set; }
        public List<ProductProcess> ProductProcess { get; set; }
        public List<ProductStock> ProductStock { get; set; }
        public List<Offers> Offers { get; set; }
        public List<OrderProducts> OrderProducts { get; set; }
        //public List<SpeacialProductDescription> SpeacialProductDescription { get; set; }
        public List<StaffProcess> StaffProcesses { get; set; }
        public List<ProductDocument> ProductDocuments { get; set; }
        public List<OrderNeeds> OrderNeeds { get; set; }
    }
}