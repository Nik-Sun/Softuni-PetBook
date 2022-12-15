using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PetBook.Core.Models.Common;
using PetBook.Core.Models.User;
using PetBook.Core.Services;
using PetBook.Infrastructure.Data.Models;
using System.Security.Claims;

using static PetBook.Infrastructure.Data.DataConstants.UserConstants;

namespace PetBook.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly SignInManager<User> signInManager;
        private readonly UserManager<User> userManager;
        private readonly IUserService userService;
        private readonly IImageService imageService;
        private readonly IEmailSender emailService;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(SignInManager<User> _signInManager,
            UserManager<User> _userManager,
            IUserService _userService,
            IImageService _imageService,
            IEmailSender emailSender,
            RoleManager<IdentityRole> _roleManager
          )
        {
            signInManager = _signInManager;
            userManager = _userManager;
            userService = _userService;
            imageService = _imageService;
            emailService = emailSender;
            roleManager = _roleManager;
        }


        [AllowAnonymous]
        [HttpGet]
        public IActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid Email or Password.");
                return View(model);
            }

            var result = await signInManager.PasswordSignInAsync(user.UserName, model.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", result.ToString());
            return View(model);
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Register()
        {
            var model = new RegisterViewModel();
            model.Cities = await userService.GetCitiesAsync();
            return View(model);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {


            if (ModelState.IsValid == false)
            {
                model.Cities = await userService.GetCitiesAsync();
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
                    AddressText = model.Address,
                    Lattitude = model.Latitude,
                    Longitude = model.Longitude
                },
                UserName = model.Username,
                Image = new Infrastructure.Data.Models.Image()
                {
                    Url = DefaultImageUrl
                }
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if (result.Succeeded == false)
            {
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                    model.Cities = await userService.GetCitiesAsync();

                }
                return View(model);
            }
            var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
            if (token != null)
            {
                
                await emailService.SendEmailAsync(user.Email, "Email confirmation", link);
            }
            bool roleExist = await roleManager.RoleExistsAsync("Visitor");
            if (roleExist == false)
            {
                await roleManager.CreateAsync(new IdentityRole("Visitor"));
            }
            await userManager.AddToRoleAsync(user, "Visitor");

            return RedirectToAction(nameof(RegisterSuccess));


        }


        [AllowAnonymous]
        public IActionResult RegisterSuccess()
        {
            return View();
        }


        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string token, string email)
        {
            var user = await userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return View("Error");
            }

            var result = await userManager.ConfirmEmailAsync(user, token);
            return View(result.Succeeded ? nameof(ConfirmEmail) : "Error");
        }


        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
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
                    Id = userId,
                    Address = user.Address,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Cities = await userService.GetCitiesAsync(),
                    ProfilePictureUrl = user.ProfilePictureUrl

                };
                return View(currentUser);
            }

            return BadRequest();
        }


        [HttpPost]
        public async Task<IActionResult> Profile(UserFormViewModel model)
        {
            if (ModelState.IsValid == false)
            {
                model.Cities = await userService.GetCitiesAsync();
                return View(model);

            }
            await userService.UpdateUser(model);
            return RedirectToAction(nameof(Profile));
        }


        [HttpPost]
        public async Task<IActionResult> UpdateProfilePicture(IFormFile image)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }
            using (var reader = image.OpenReadStream())
            {
                string url = await imageService.Upload(reader);
                return Ok(JsonConvert.SerializeObject(url));
            }
        }


        [AllowAnonymous]
        [HttpGet]
        [Route("Api/CheckUsername/{username?}")]
        public async Task<IActionResult> IsUsernameTaken([FromRoute] string username)
        {
            bool isAvaliable = await userService.CheckUsernameAvailability(username);
            return Ok(isAvaliable);
        }


        public IActionResult ForgotPassword()
        {
            var model = new ForgotPasswordModel();
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Email not found");
                return View(model);
            }
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var link = Url.Action(nameof(ResetPassword), "User", new { token, email = user.Email }, Request.Scheme);

            await emailService.SendEmailAsync(user.Email, "Password reset", link);
            return RedirectToAction(nameof(ResetPasswordSuccess));
           
        }


        public IActionResult ResetPasswordSuccess()
        {
            return View();
        }
        
        public async Task<IActionResult> ResetPassword(string token,string email)
        {
            var user = userManager.FindByEmailAsync(email);
            if (user == null)
            {
                return View("Error");
            }
            userManager.ResetPasswordAsync(user,token,)
        }
    }
}
