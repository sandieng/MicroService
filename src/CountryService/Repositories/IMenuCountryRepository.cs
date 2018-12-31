using CountryService.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Repositories
{
    public interface IMenuCountryRepository
    { 
        Task<IEnumerable<MenuCountry>> GetAll();
        Task<MenuCountry> GetById(int id);
    }
}
