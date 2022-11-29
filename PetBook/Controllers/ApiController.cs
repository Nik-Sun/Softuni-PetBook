using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace PetBook.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/like")]
  
    public class ApiController : Controller
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Like([FromRoute]string id)
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return Ok(new { id, currentUserId });
        }
    }
}
