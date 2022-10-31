using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Data.Models;
using PetBook.Models.User;

namespace PetBook.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        public UserController(SignInManager<User> _signInManager, 
            UserManager<User> _userManager)
        {
            signInManager = _signInManager;
            userManager = _userManager;
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

        public IActionResult Register()
        {

        }
    }
}
