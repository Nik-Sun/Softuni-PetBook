using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.Pets;

namespace PetBook.Core.Services
{
    public interface IPetService
    {
        public IEnumerable<BreedDto> GetBreeds();
        public Task AddPetAsync(PetFormModel model);
        public Task<PetBrowseModel> GetAll(string userId,int pageNumber = 1);

        public Task<PetDetailViewModel> GetPetById(string id);
        public Task<PetBrowseModel> SearchPets(string criteria,string search,string userId);
    }
}
