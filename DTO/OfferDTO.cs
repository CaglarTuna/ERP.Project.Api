using System;

namespace DTO
{
    public class OfferDTO : BaseDTO
    {
       
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public ProductDTO Products { get; set; }
        public int? CurrencyId { get; set; }
        public CurrenciesDTO Currencies { get; set; }
        public int? Quantitiy { get; set; }
        public string UnitCost { get; set; }
        public string TotalCost { get; set; }
        public string UnitOfferAmount { get; set; }
        public string LineOfferAmount { get; set; }
        public DateTime? FinishDate { get; set; }
        public string CustomerReply { get; set; }
        public string Kdv { get; set; }
        public int? PaymentTerm { get; set; }
        public int? OfferStatuId { get; set; }
    }
}
