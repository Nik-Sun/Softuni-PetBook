using Microsoft.EntityFrameworkCore;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;

namespace PetBook.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;

        public UserService(IRepository _repo)
        {
            repo = _repo;
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
