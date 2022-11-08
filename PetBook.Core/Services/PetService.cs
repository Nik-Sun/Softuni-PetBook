using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.Pets;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Services
{
    public class PetService : IPetService
    {
        private readonly IRepository repo;
        public PetService(IRepository _repo)
        {
            repo = _repo;
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
                
            };
          

            foreach (var img in model.Images)
            {
                string path = Path.GetFullPath($"{AppDomain.CurrentDomain.BaseDirectory}/../../../../PetBook.Infrastructure/Images/PetImages/{Guid.NewGuid()}.jpg");
                using (var stream = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    await img.CopyToAsync(stream);
                }
                pet.Images.Add(new Image()
                {
                    Url = path
                });
            }

            await repo.AddAsync(pet);
            await repo.SaveChangesAsync();
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
    }
}
