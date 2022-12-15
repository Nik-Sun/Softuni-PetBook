using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using PetBook.Core.Models.Pets;
using PetBook.Core.Services;
using System.Security.Claims;

namespace PetBook.Controllers
{
    [Authorize]
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
         
            if (TempData.Any())
            {
                foreach (var err in TempData.Keys)
                {
                    ModelState.AddModelError("", TempData[err] as string);
                }
               
            }
            var model = await petService.GetPetById(petId);

            if (User.FindFirstValue(ClaimTypes.NameIdentifier) != model.OwnerId)
            {
                return BadRequest();
            }

            var editModel = new PetEditModel()
            {
                Id = model.Id.ToString(),
                Description = model.Description,
                Age = model.Age,
                Weight = model.Weight,
                Height = model.Height,
                Breed = model.Breed,
                Size = model.Size,
                ImageViewModels = model.Images,
                IsMale = model.IsMale,
                Likes = model.Likes,
                Name = model.Name
            };
            return View(editModel);
        }


        [HttpPost]
        public async Task<IActionResult> Edit(PetEditModel model)
        {

            if (ModelState.IsValid == false)
            {
                foreach (var value in ModelState.Values)
                {
                    
                    if (value.ValidationState == ModelValidationState.Invalid)
                    {
                        for (int i = 0; i < value.Errors.Count; i++)
                        {
                            TempData.Add($"Error [{new Random().Next()}]", value.Errors[i].ErrorMessage);
                        }
                    }
                    
                }
               
            }
            bool limit = await petService.ImageLimitReached(model.Id, model.Images.Count);

            if (limit)
            {
                TempData.Add($"Error [{new Random().Next()}]", "You cannot upload more than 12 images");
            }
            else
            {
                await petService.EditPet(model);
            }

            return RedirectToAction(nameof(Edit), new { petId = model.Id });

        }

        public async Task<IActionResult> Delete(string petId)
        {
            await petService.DeletePet(petId);
            return RedirectToAction(nameof(MyPets));
        }
        public async Task<IActionResult> DeleteImage(string imageId,string petId)
        {
            await petService.DeleteImage(imageId);
            return RedirectToAction(nameof(Edit),new {petId = petId });
        }
    }
}
