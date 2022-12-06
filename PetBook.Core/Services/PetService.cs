using Microsoft.EntityFrameworkCore;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.Common;
using PetBook.Core.Models.Pets;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;
using System.Linq.Expressions;

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
                //using (var stream =img.OpenReadStream())
                //{
                //    var path = await imageService.Upload("pet-images",stream);
                //    pet.Images.Add(new Image()
                //    {
                //        Url = path
                //    });
                //}
                pet.Images.Add(new Image()
                {
                    Url = "1"
                });
            }

            await repo.AddAsync(pet);
            await repo.SaveChangesAsync();
        }

        public async Task<PetBrowseModel> GetAll(string userId, int pageNumber = 1)
        {

            //double maxPageNumber = Math.Ceiling(repo.AllReadonly<Pet>().Count() / 6.0);
            //if (pageNumber > maxPageNumber)
            //{
            //    pageNumber = (int)maxPageNumber;
            //}
            //int take = 6;
            //int skip = (take * pageNumber) - take;
            var pets = repo.AllReadonly<Pet>();
            //var pets = await repo.AllReadonly<Pet>()
            //      .Include(p => p.Owner)
            //      .Include(p => p.LikedBy)
            //      .Skip(skip)
            //      .Take(take)
            //      .Select(p => new PetViewModel()
            //      {
            //          Id = p.Id,
            //          Owner = $"{p.Owner.FirstName} {p.Owner.LastName}",
            //          Name = p.Name,
            //          IsMale = p.IsMale,
            //          Likes = p.LikedBy.Count(),
            //          CanLike = p.LikedBy.Any(l=> (l.UserId == userId) ) == false &&
            //          p.OwnerId != userId,
            //          Images = p.Images.Select(i => new ImageViewModel()
            //          {
            //              Id = i.Id.ToString(),
            //              Url = i.Url
            //          }).ToList(),
            //      }).ToListAsync();

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

                    return result;

                case "ownerName":
                    pets = repo.AllReadonly<Pet>(p => p.Owner.FirstName.Contains(search) || p.Owner.LastName.Contains(search));
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



    }
}
