using CountryService.DTOs;
using CountryService.Entities;
using CountryService.Mappers;
using CountryService.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CountryService.API.Controllers
{
    [Route("api/v1/countryservice")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService _countryService;
        private IMapper<MenuCountry, CountryRequest, CountryResponse> _mapper;

        public CountryController(ICountryService countryService, IMapper<MenuCountry, CountryRequest, CountryResponse> mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        // GET /countries
        [HttpGet]
        [Route("countries")]
        public async Task<ActionResult<IEnumerable<MenuCountry>>> Get()
        {
            try
            {
                var countries = await _countryService.GetAll();
                var response = _mapper.MapToResponse(countries);
                return Ok(response);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        // GET /country/5
        [HttpGet("country/{id}")]
        public async Task<ActionResult<MenuCountry>> Get(int id)
        {
            try
            {
                var country = await _countryService.GetById(id);
                return Ok(country);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        // POST api/v1/countryservice
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/v1/countryservice/country/5
        [HttpPut("/country/{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/v1/countryservice/country/5
        [HttpDelete("/country/{id}")]
        public void Delete(int id)
        {
        }
    }
}
