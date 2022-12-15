using Microsoft.EntityFrameworkCore;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.Common;
using PetBook.Core.Models.Pets;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;

using static PetBook.Infrastructure.Data.DataConstants.MinioBuckets;
using static PetBook.Infrastructure.Data.DataConstants.PetConstants;
namespace PetBook.Core.Services
{
    public class PetService : IPetService
    {
        private readonly IRepository repo;
        private readonly IImageService imageService;
        public PetService(IRepository _repo
            , IImageService _imageService)
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

                pet.Images.Add(new Image()
                {
                    Url = await imageService.Upload(PetBucket, img.OpenReadStream())
                });
            }

            await repo.AddAsync(pet);
            await repo.SaveChangesAsync();
        }

        public async Task<PetBrowseModel> GetAll(string userId, int pageNumber = 1)
        {
            var pets = repo.AllReadonly<Pet>();

            return await GetBrowseModelAsync(pets, userId, pageNumber);
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
                .Include(p => p.LikedBy)
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
                Height = pet.Height,
                Weight = pet.Weight,
                Age = pet.Age,
                Likes = pet.LikedBy.Count()
            };
        }

        public async Task<PetBrowseModel> SearchPets(string criteria, string search, string userId)
        {
            var result = new PetBrowseModel();
            IQueryable<Pet>? pets;
            switch (criteria)
            {
                case "breed":
                    pets = repo.AllReadonly<Pet>(p => p.Breed.Name.Contains(search));
                    result = await GetBrowseModelAsync(pets, userId);
                    break;
                case "size":

                    if (search == "Toy")
                    {
                        pets = repo.AllReadonly<Pet>(p => p.Weight <= 5.5);
                    }
                    else if (search == "Small")
                    {
                        pets = repo.AllReadonly<Pet>(p => p.Weight >= 5.5 && p.Weight < 10);
                    }
                    else if (search == "Medium")
                    {
                        pets = repo.AllReadonly<Pet>(p => p.Weight >= 10 && p.Weight < 26);
                    }
                    else if (search == "Large")
                    {
                        pets = repo.AllReadonly<Pet>(p => p.Weight >= 26 && p.Weight < 45);
                    }
                    else if (search == "Giant")
                    {
                        pets = repo.AllReadonly<Pet>(p => p.Weight >= 45);
                    }
                    else
                    {
                        return result;
                    }
                    break;

                case "ownerName":
                    pets = repo.AllReadonly<Pet>(p => p.Owner.FirstName.Contains(search) || p.Owner.LastName.Contains(search));
                    break;

                case "petName":
                    pets = repo.AllReadonly<Pet>(p => p.Name.Contains(search));
                    break;
                default:
                    return result;

            }
            result = await GetBrowseModelAsync(pets, userId);
            return result;
        }

        private string GetSize(double w)
        {
            if (w < 5.5)
            {
                return "Toy";
            }
            else if (w >= 5.5 && w < 10)
            {
                return "Small";
            }
            else if (w >= 10 && w < 26)
            {
                return "Medium";
            }
            else if (w >= 26 && w < 45)
            {
                return "Large";
            }
            else
            {
                return "Giant";
            }
        }

        private async Task<PetBrowseModel> GetBrowseModelAsync(IQueryable<Pet> pets, string userId, int page = 1)
        {
            double maxPageNumber = Math.Ceiling(repo.AllReadonly<Pet>().Count() / 6.0);
            if (page > maxPageNumber)
            {
                page = (int)maxPageNumber;
            }
            int take = 6;
            int skip = (take * page) - take;

            var model = await pets
                  .Include(p => p.Owner)
                  .Include(p => p.LikedBy)
                  .Skip(skip)
                  .Take(take)
                  .Select(p => new PetViewModel()
                  {
                      Id = p.Id,
                      Owner = $"{p.Owner.FirstName} {p.Owner.LastName}",
                      OwnerId = p.OwnerId,
                      Name = p.Name,
                      IsMale = p.IsMale,
                      Likes = p.LikedBy.Count(),
                      CanLike = p.LikedBy.Any(l => (l.UserId == userId)) == false &&
                      p.OwnerId != userId,
                      Images = p.Images.Select(i => new ImageViewModel()
                      {
                          Id = i.Id.ToString(),
                          Url = i.Url
                      }).ToList(),
                  }).ToListAsync();

            return new PetBrowseModel()
            {
                Page = page,
                Pets = model,
            };
        }

        public async Task<PetBrowseModel> GetPetsOwnedByUser(string userId)
        {
            var pets = repo.AllReadonly<Pet>(p => p.OwnerId == userId);
            var model = await GetBrowseModelAsync(pets, userId);

            return model;
        }

        public async Task EditPet(PetEditModel model)
        {
            Guid id;
            if (Guid.TryParse(model.Id, out id))
            {
                var pet = await repo.GetByIdAsync<Pet>(id);
                pet.Name = model.Name;
                pet.Age = model.Age;
                pet.Description = model.Description;
                pet.Height = model.Height;
                pet.Weight = model.Weight;
                foreach (var image in model.Images)
                {
                    using (var stream = image.OpenReadStream())
                    {
                        pet.Images.Add(new Image()
                        {
                            Url = await imageService.Upload(PetBucket, stream)
                        });
                    }
                }
                await repo.SaveChangesAsync();
            }
        }

        public async Task<bool> ImageLimitReached(string petId, int uploadedImagesCount)
        {
            Guid id;
            if (Guid.TryParse(petId,out id))
            {
                int count =  await repo.AllReadonly<Pet>(p => p.Id == id)
                    .Select(p => p.Images.Count())
                    .FirstAsync();
                if (count > MaxPetImagesCount)
                {
                    return true;
                }

            }
           return false;
        }

        public async Task DeletePet(string petId)
        {
            Guid id;

            if (Guid.TryParse(petId,out id))
            {
                var pet = await repo.All<Pet>(p => p.Id == id)
                    .Include(p => p.Images)
                    .FirstOrDefaultAsync();
                
                if (pet != null)
                {
                    repo.Delete(pet);

                    await repo.SaveChangesAsync();
                    return;
                }
            }
            throw new ArgumentException(petId);
        }

        public async Task DeleteImage(string imageId)
        {
            int id;
            if (int.TryParse(imageId,out id))
            {
                var image =await repo.GetByIdAsync<Image>(id);
                repo.Delete(image);
                await repo.SaveChangesAsync();
                return;
            }
            throw new ArgumentException("Id");
           
        }
    }
}
