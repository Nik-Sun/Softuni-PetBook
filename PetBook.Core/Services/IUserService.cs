using PetBook.Core.Data.Models.DTOs;

namespace PetBook.Core.Services
{
    public interface IUserService
    {
        public Task<ICollection<CityDTO>> GetCitiesAsync();
    }
}
