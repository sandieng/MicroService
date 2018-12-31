using CountryService.Repositories;
using CountryService.Services;
using GenericRepository;
using CountryService.Mappers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CountryService.Entities;
using CountryService.DTOs;

namespace CountryService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration["connectionStrings:countryServiceConnectionString"];
            services.AddDbContext<MenuCountryDbContext>(o => o.UseSqlServer(connectionString));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddScoped(typeof(IMapper<MenuCountry, CountryRequest, CountryResponse>), typeof(MenuCountryMapper));
            services.AddScoped<ICountryService, Services.CountryService>();
            services.AddScoped(typeof(IMenuCountryRepository), typeof(MenuCountryRepository));
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            //services.AddScoped(typeof(IMenuCountryRepository<>), typeof(MenuCountryRepository<>));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
