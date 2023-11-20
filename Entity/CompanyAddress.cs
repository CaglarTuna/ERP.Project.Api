namespace Entity
{
    public class CompanyAddress : Base
    {
        public int? CountryId { get; set; }
        //public Countries Countries { get; set; }
        public int? CityId { get; set; }
        //public Cities Cities { get; set; }
        public int? CompanyId { get; set; }
        public Companies Companies { get; set; }
        public string? PostCode { get; set; }
        public string? AddressTitle { get; set; }
        public string? Address { get; set; }
    }
}