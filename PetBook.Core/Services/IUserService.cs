using PetBook.Core.Data.Models.DTOs;
using PetBook;
using PetBook.Infrastructure.Data.Models.DTOs;

namespace PetBook.Core.Services
{
    public interface IUserService
    {
        public Task<ICollection<CityDTO>> GetCitiesAsync();
        public Task<UserDto> FindUserByIdAsync(string id);
    }
}
