using Microsoft.EntityFrameworkCore;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;
using PetBook.Infrastructure.Data.Models.DTOs;

namespace PetBook.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
        }

        public async Task<UserDto> FindUserByIdAsync(string id)
        {
            var user = await repo.GetByIdAsync<User>(id);
            var address = await repo.GetByIdAsync<Address>(user.AddressId);

            if (user != null)
            {
                return new UserDto()
                {
                    Address = address.AddressText,
                    Cities = await GetCitiesAsync(),
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,

                };
            }
            throw new ArgumentException("id");
        }

        public async Task<ICollection<CityDTO>> GetCitiesAsync()
        {
            var cities = await repo.AllReadonly<City>()
                .Select(c => new CityDTO()
                { 
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();

            return cities;
        }

        
    }
}
