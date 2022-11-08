﻿using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Models.User;

namespace PetBook.Core.Services
{
    public interface IUserService
    {
        public Task<ICollection<CityDTO>> GetCitiesAsync();
        public Task<UserFormViewModel> FindUserByIdAsync(string id);
    }
}
