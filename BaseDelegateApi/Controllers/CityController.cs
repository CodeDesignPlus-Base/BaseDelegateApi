using BaseDelegateApi.Services.City;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BaseDelegateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService service;

        public CityController(ICityService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var data = await this.service.GetCitiesAsync();

            return Ok(data);
        }
    }
}
