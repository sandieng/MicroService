namespace CountryService.DTOs
{
    public class CountryResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CallingCode { get; set; }
        public decimal GST { get; set; }
        public int? CurrencyId { get; set; }
    }
}
