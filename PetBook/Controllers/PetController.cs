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

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Browse([FromRoute]int id = 1)
        {
            PetBrowseModel pets;
            if (id == 1)
            {
                pets = await petService.GetAll();
                return View(pets);
            }
            pets = await petService.GetAll(id);
            return View(pets);
        }
        //[HttpPost]
        //public async Task<IActionResult> Browse(int page)
        //{
        //    var pets = await petService.GetAll(page);
        //    return View(pets);
        //}

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var model = await petService.GetPetById(id);
            return View(model);
        }
    }
}
