using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Services;
using System.Security.Claims;

namespace PetBook.Controllers
{
    [Authorize]
    [ApiController]
    [Route("Api/Like")]

    public class ApiController : Controller
    {
        private readonly ILikeService likeService;

        public ApiController(ILikeService _likeService)
        {
            likeService= _likeService;
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> Like(string id)
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var totalLikes = await likeService.AddLike(currentUserId,id);
            return Ok(totalLikes);
        }
    }
}
