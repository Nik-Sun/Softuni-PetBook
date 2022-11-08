using PetBook.Core.Data.Models.DTOs;

namespace PetBook.Core.Services
{
    public interface IPetService
    {
        public IEnumerable<BreedDto> GetBreeds();
        public Task AddPetAsync(PetFormModel model);
    }
}
