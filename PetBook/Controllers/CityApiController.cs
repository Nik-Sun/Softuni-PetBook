using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Services;

namespace PetBook.Controllers
{
    
    [ApiController]
    [Route("Api/City")]
    public class CityApiController : Controller
    {
        private ICityService cityService;
        public CityApiController(ICityService _cityService)
        {
            cityService = _cityService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
           var result = await cityService.GetLocationDataForCity(id);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
