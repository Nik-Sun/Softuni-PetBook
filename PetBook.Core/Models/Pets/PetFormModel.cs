using Microsoft.AspNetCore.Http;
using PetBook.Core.Data.Models.DTOs;


namespace PetBook.Core.Models.Pets
{
    public class PetFormModel : PetModel
    {

        public int BreedId { get; set; }

        public IEnumerable<BreedDto>? Breeds { get; set; }

        
        public string? OwnerId { get; set; } = null!;

    }
}
