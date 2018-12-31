using CountryService.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<MenuCountry>> GetAll();
        Task<MenuCountry> GetById(int id);
    }
}
