using Microsoft.EntityFrameworkCore;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.User;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;
using static PetBook.Infrastructure.Data.DataConstants.UserConstants;

namespace PetBook.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IRepository repo;
        private readonly IImageService imageService;

        public UserService(IRepository _repo
            ,IImageService _imageService)
        {
            repo = _repo;
            imageService = _imageService;
        }

        public async Task<UserFormViewModel> FindUserByIdAsync(string id)
        {
            var user = await repo.AllReadonly<User>(u => u.Id == id)
                .Include(u => u.Image)
                .Include(u => u.Address)
                .FirstOrDefaultAsync();
           

            if (user != null)
            {
                return new UserFormViewModel()
                {
                    Address = user.Address.AddressText,
                    Cities = await GetCitiesAsync(),
                    Email = user.Email,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    ProfilePictureUrl = user.Image.Url

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

        public async Task UpdateUser(UserFormViewModel model)
        {
            var user = await repo.All<User>(u => u.Id == model.Id)
                .Include(u => u.Address)
                .Include(u => u.Image)
                .FirstOrDefaultAsync();
            if (user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                user.Address.AddressText = model.Address;
                
                if (model.ProfilePicture != null)
                {
                    var oldImageUrl = user.Image.Url;
                    if (oldImageUrl != DefaultImageUrl)
                    {
                        
                        string imageName = oldImageUrl
                            .Split("/",StringSplitOptions.RemoveEmptyEntries)
                            .Last();
                        await imageService.Delete("user-images", imageName);
                    }
                    var imageUrl = await imageService.Upload("user-images", model.ProfilePicture.OpenReadStream());
                    user.Image = new Image()
                    {
                        Url = imageUrl
                    };
                }
               
                await repo.SaveChangesAsync();
                return;
            }
            throw new ArgumentException("User.Id");
        }

       
    }
}
