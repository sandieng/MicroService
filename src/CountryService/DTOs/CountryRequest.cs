using System.ComponentModel.DataAnnotations;

namespace CountryService.DTOs
{
    public class CountryRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CallingCode { get; set; }
        [Required]
        public decimal GST { get; set; }
        public int? CurrencyId { get; set; }
    }
}
