using BaseDelegateApi.Services.Country;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BaseDelegateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryService service;

        public CountryController(ICountryService service)
        {
            this.service = service;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await this.service.GetCountriesAsync();

            return Ok(data);
        }
    }
}
