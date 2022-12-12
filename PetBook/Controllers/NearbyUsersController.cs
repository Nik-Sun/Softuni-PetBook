using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Models.User;
using PetBook.Core.Services;
using System.Security.Claims;

namespace PetBook.Controllers
{
    public class NearbyUsersController : Controller
    {
        private readonly IUserService userService;

        public NearbyUsersController(IUserService _userService)
        {
            userService = _userService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> NearbyUsers()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var users = await userService.GetUsersNearby(currentUserId);
            if (users == null)
            {
                return BadRequest();
            }
            return Ok(users);
        }
    }
}
