using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Services
{
    public interface ILikeService
    {
        public Task<int> AddLike(string userId,string petId);
    }
}
