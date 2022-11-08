using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Models.Pets;
using PetBook.Core.Services;
using System.Security.Claims;

namespace PetBook.Controllers
{
    public class PetController : Controller
    {
        private readonly IPetService petService;

        public PetController(IPetService _petService)
        {
            petService = _petService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var model = new PetFormModel();
            model.Breeds = petService.GetBreeds();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(PetFormModel model)
        {
            model.OwnerId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid == false)
            {
                model.Breeds = petService.GetBreeds();
                return View(model);
            }
            
            await petService.AddPetAsync(model);

            return RedirectToAction("Index","Home");
        }

        public async Task<IActionResult> Browse()
        {
            return View();
        }
    }
}
