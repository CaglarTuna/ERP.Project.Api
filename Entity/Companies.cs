using System.Collections.Generic;

namespace Entity
{
    public class Companies : Base
    {
        public string? Name { get; set; }
        public string? TaxNumber { get; set; }
        public string? TaxOffice { get; set; }
        public string? Department { get; set; }
        public string? ContactPerson { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Telephone { get; set; }
        public string? Prefix { get; set; }
        public List<ConsumptionMaterials> ConsumptionMaterials { get; set; }
        public List<CompanyAddress> CompanyAddress { get; set; }
        public List<ConsumptionMaterialStock> ConsumptionMaterialStock { get; set; }
        public List<ConsumptionMaterialSuppliers> ConsumptionMaterialSuppliers { get; set; }
        public List<MaterialSuppliers> MaterialSuppliers { get; set; }
        public List<MaterialSupplyRequests> MaterialSupplyRequests { get; set; }
        public List<Orders> Orders { get; set; }
        public List<SawdustStock> SawdustStocks { get; set; }
        public List<MaterialStock> MaterialStocks { get; set; }
        public List<MaterialCertificates> MaterialCertificates { get; set; }
    }
}