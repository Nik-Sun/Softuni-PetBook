using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.User;

namespace PetBook.Core.Services
{
    public interface IUserService
    {
        public Task<ICollection<CityDTO>> GetCitiesAsync();
        public Task<UserFormViewModel> FindUserByIdAsync(string id);
        public Task UpdateUser(UserFormViewModel model);
        public Task<IEnumerable<UserNearbyModel>> GetUsersNearby(string userId);
        public Task<bool> CheckUsernameAvailability(string username);


    }
}
