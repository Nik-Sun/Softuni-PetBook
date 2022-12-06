using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
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
            ViewBag.SearchModel = new SearchModel(); 
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
    }
}
