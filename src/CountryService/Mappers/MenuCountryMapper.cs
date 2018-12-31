using System.Collections.Generic;
using System.Linq;
using CountryService.DTOs;
using CountryService.Entities;

namespace CountryService.Mappers
{
    public class MenuCountryMapper : IMapper<MenuCountry, CountryRequest, CountryResponse>
    {
        public MenuCountry MapFromRequest(CountryRequest countryRequest)
        {
            return new MenuCountry
            {
                Id = countryRequest.Id,
                Name = countryRequest.Name,
                CallingCode = countryRequest.CallingCode,
                GST = countryRequest.GST,
                CurrencyId = countryRequest.CurrencyId

            };
        }

        public CountryResponse MapToResponse(MenuCountry country)
        {
            return new CountryResponse
            {
                Id = country.Id,
                Name = country.Name,
                CallingCode = country.CallingCode,
                GST = country.GST,
                CurrencyId = country.CurrencyId
            };
        }

        public IEnumerable<CountryResponse> MapToResponse(IEnumerable<MenuCountry> countries)
        {
            return countries.Select(MapToResponse).ToList();
        }
    }
}
