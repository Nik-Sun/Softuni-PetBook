using PetBook.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Services
{
    public interface ICityService
    {
        public Task<LocationData> GetLocationDataForCity(int id);
    }
}
