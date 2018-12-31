using CountryService.Entities;
using GenericRepository;
using Microsoft.EntityFrameworkCore;

namespace CountryService.Repositories
{
    public class MenuCountryRepository : GenericRepository<MenuCountry>, IMenuCountryRepository
    {
        private MenuCountryDbContext _context;
        private DbSet<MenuCountry> _entity;

        public MenuCountryRepository(MenuCountryDbContext context) : base(context)
        {
            _context = context;
            _entity = _context.Set<MenuCountry>();
        }

        // ========================================================
        // Implemented in Generic Repository
        // ========================================================
        //public async Task<IEnumerable<MenuCountry>> GetAll()
        //{
        //    return await _entity.ToListAsync();
        //}

        //public async Task<MenuCountry> GetById(int id)
        //{
        //    return await _entity.FindAsync(id);
        //}
    }
}
