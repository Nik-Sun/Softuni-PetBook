using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Models.User;
using PetBook.Core.Services;
using PetBook.Infrastructure.Data.Models;
using System.Security.Claims;

namespace PetBook.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly IUserService userService;
        public UserController(SignInManager<User> _signInManager, 
            UserManager<User> _userManager,
            IUserService _userService)
        {
            signInManager = _signInManager;
            userManager = _userManager;
            userService = _userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);
            if(user == null)
            {
                ModelState.AddModelError("","Invalid Email or Password.");
                return View(model);
            }

            var result = await signInManager.PasswordSignInAsync(user.UserName,model.Password,false,false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index","Home");
            }

            ModelState.AddModelError("", "Something went wrong.");
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            var model = new RegisterViewModel();
            model.Cities = await userService.GetCitiesAsync();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            model.Cities = await userService.GetCitiesAsync();
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            var user = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Address = new Address()
                {
                    CityId = model.CityId,
                    AddressText = model.Address
                },
                UserName = model.FirstName
            };

            var result = await userManager.CreateAsync(user,model.Password);

            if (result.Succeeded == false)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("" , err.Description);
                }
                return View(model);
            }
            await signInManager.PasswordSignInAsync(user,model.Password,false,false);
            return RedirectToAction("Index","Home");

            
        }
        public async Task< IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                var user = await userService.FindUserByIdAsync(userId);
                var currentUser = new UserFormViewModel()
                {
                    Address = user.Address,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Cities = await userService.GetCitiesAsync()
                };
                return View(currentUser);
            }

            return BadRequest();
        }
    }
}
