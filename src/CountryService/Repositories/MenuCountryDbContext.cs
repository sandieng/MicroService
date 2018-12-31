using Microsoft.EntityFrameworkCore;
using CountryService.Entities;
using GenericRepository;

namespace CountryService.Repositories
{
    public class MenuCountryDbContext : DbContextGeneric<MenuCountryDbContext>
    {
        public virtual DbSet<MenuCountry> MenuCountry { get; set; }

        public MenuCountryDbContext(DbContextOptions<MenuCountryDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
