using CountryService.Entities;
using CountryService.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.Services
{
    public class CountryService : ICountryService
    {
        private MenuCountryDbContext _context;
        private IMenuCountryRepository _repo;

        public CountryService()
        {
        }

        public CountryService(MenuCountryDbContext context, IMenuCountryRepository repo)
        {
            _context = context;
            _repo = repo;
        }

        public async Task<IEnumerable<MenuCountry>> GetAll()
        {
            return await _repo.GetAll();
        }

        public async Task<MenuCountry> GetById(int id)
        {
            var country = await _repo.GetById(id);
            if (country == null) return null;

            return country;
        }
    }
}
