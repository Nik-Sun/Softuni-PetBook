using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Services;
using PetBook.Models.Pets;

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
            if (ModelState.IsValid == false)
            {
                model.Breeds = petService.GetBreeds();
                return View(model);
            }
            

            return View();
        }
    }
}
