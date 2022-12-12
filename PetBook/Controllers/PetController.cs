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

        [ResponseCache(Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Browse([FromRoute]int id = 1)
        {
          
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            PetBrowseModel pets;
            if (id <= 1)
            {
                pets = await petService.GetAll(currentUserId);
                return View(pets);
            }
            pets = await petService.GetAll(currentUserId, id);
            return View(pets);
        }
        

        [HttpGet]
        public async Task<IActionResult> Details(string id)
        {
            var model = await petService.GetPetById(id);
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> Search(PetBrowseModel model)
        {
           
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Browse));
            }
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await petService.SearchPets(model.Criteria, model.Search, userId);
            result.IsSearch = true;
            return View("Browse",result);
        }
        

        public async Task<IActionResult> MyPets()
        {
            string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var pets = await petService.GetPetsOwnedByUser(currentUserId);
            return View(nameof(Browse), pets);
        }

        public async Task<IActionResult> Edit(string petId)
        {
            var model = await petService.GetPetById(petId);
            return View(model);
        }
    }
}
