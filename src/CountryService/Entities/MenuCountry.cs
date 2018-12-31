using GenericRepository;

namespace CountryService.Entities
{
    public class MenuCountry : IEntity
    {
        public virtual int Id { get; set; }
        public string Name { get; set; }
        public string CallingCode { get; set; }
        public decimal GST { get; set; }
        public int? CurrencyId { get; set; }
    }
}
