using System;
using System.Collections.Generic;

namespace Entity
{
    public class ConsumptionMaterials : Base
    {
        public int? CurrencyId { get; set; }
        public Currencies Currencies { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
        public int? UnitsOfMeasureId { get; set; }
        public UnitsOfMeasure UnitsOfMeasure { get; set; }
        //public int? ConsumptionUnitId { get; set; }
        //public virtual UnitsOfMeasure ConsumptionUnits { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? CostPrice { get; set; }
        public int? MinStockQuantity { get; set; }
        public int? UniqueNo { get; set; }
        public DateTime? EntryDate { get; set; }
        public DateTime? ExitDate { get; set; }
        public string? ConsumptionMaterialAddress { get; set; }
        public string? StockNo { get; set; }
        public int? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string? BarcodeNo { get; set; }
        public float? Quantity { get; set; }
        public List<ConsumptionMaterialStock> ConsumptionMaterialStock { get; set; }
        public List<ConsumptionMaterialSuppliers> ConsumptionMaterialSuppliers { get; set; }
    }
}