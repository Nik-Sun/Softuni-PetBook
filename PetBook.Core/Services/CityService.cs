using Microsoft.EntityFrameworkCore;
using PetBook.Core.Models.User;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;

namespace PetBook.Core.Services
{
    public class CityService : ICityService
    {

        private readonly IRepository repo;
        public CityService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<LocationData> GetLocationDataForCity(int id)
        {
            var data = new LocationData();
            var cicy = await repo.AllReadonly<City>(c => c.Id == id)
                .FirstAsync();
            data.Lattitude = cicy.Lattitude;
            data.Longitude = cicy.Longitude;
            return data;
        }
    }
}
