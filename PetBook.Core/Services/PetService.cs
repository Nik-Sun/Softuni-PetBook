using Microsoft.EntityFrameworkCore;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.Common;
using PetBook.Core.Models.Pets;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;

namespace PetBook.Core.Services
{
    public class PetService : IPetService
    {
        private readonly IRepository repo;
        private readonly IImageService imageService;
        public PetService(IRepository _repo
            ,IImageService _imageService)
        {
            repo = _repo;
            imageService = _imageService;
        }

        public async Task AddPetAsync(PetFormModel model)
        {
            var pet = new Pet()
            {
                Name = model.Name,
                Age = model.Age,
                BreedId = model.BreedId,
                Description = model.Description,
                Height = model.Height,
                Weight = model.Weight,
                OwnerId = model.OwnerId,
                IsMale = model.IsMale,
            };


            foreach (var img in model.Images)
            {
                using (var stream =img.OpenReadStream())
                {
                    var path = await imageService.Upload("pet-images",stream);
                    pet.Images.Add(new Image()
                    {
                        Url = path
                    });
                }
               
            }

            await repo.AddAsync(pet);
            await repo.SaveChangesAsync();
        }

        public async Task<IEnumerable<PetViewModel>> GetAll(int pageNumber = 1)
        {
            int take = 6;
            int skip = (take * pageNumber) - take;

            var pets = repo.AllReadonly<Pet>()
                  .Include(p => p.Owner)
                  .Skip(skip)
                  .Take(take)
                  .Select(p => new PetViewModel()
                  {
                      Id = p.Id,
                      Owner = $"{p.Owner.FirstName} {p.Owner.LastName}",
                      Name = p.Name,
                      IsMale=p.IsMale,
                      Images = p.Images.Select(i => new ImageViewModel()
                      {
                          Id = i.Id.ToString(),
                          Url = i.Url
                      }).ToList(),
                  });
            return await pets.ToListAsync();
        }

        public IEnumerable<BreedDto> GetBreeds()
        {
            var breeds = repo.AllReadonly<Breed>()
                .Select(b => new BreedDto()
                {
                    Id = b.Id,
                    Name = b.Name,
                }).ToList();

            return breeds;
        }

        public async Task<PetDetailViewModel> GetPetById(string id)
        {
            var petId = Guid.Parse(id);
            var pet = await repo.All<Pet>().Where(p => p.Id == petId)
                .Include(o => o.Owner)
                .Include(b => b.Breed)
                .Include(i => i.Images)
                .FirstOrDefaultAsync();
            if (pet == null)
            {
                throw new ArgumentException("Id");
            }
            return new PetDetailViewModel()
            {
                Name = pet.Name,
                Images = pet.Images.Select(i => new ImageViewModel()
                {
                    Url = i.Url,
                    Id = i.Id.ToString(),
                }).ToList(),
                Owner = $"{pet.Owner.FirstName} {pet.Owner.LastName}",
                IsMale = pet.IsMale,
                Description = pet.Description,
                Breed = pet.Breed.Name,
                OwnerId = pet.OwnerId,
                Size = GetSize(pet.Weight),
                Id = pet.Id,
            };
        }


        private string GetSize(double w)
        {
            if (w<5.5)
            {
                return "Toy";
            }
            else if (w>= 5.5 && w< 10)
            {
                return "Small";
            }
            else if (w>=10 && w < 26)
            {
                return "Medium";
            }
            else if (w>=26 && w<45)
            {
                return "Large";
            }
            else
            {
                return "Giant";
            }
        }
    }
}
