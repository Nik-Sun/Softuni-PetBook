using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.Pets;

namespace PetBook.Core.Services
{
    public interface IPetService
    {
        public IEnumerable<BreedDto> GetBreeds();
        public Task AddPetAsync(PetFormModel model);
    }
}
