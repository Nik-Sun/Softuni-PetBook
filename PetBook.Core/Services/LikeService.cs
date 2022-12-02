using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Services
{
    public class LikeService : ILikeService
    {
        private readonly IRepository repo;
        public LikeService(IRepository _repo)
        {
            repo = _repo;
        }
        public async Task<int> AddLike(string userId, string petIdString)
        {
            var petId = new Guid(petIdString);
            var like = new Like()
            {
                UserId = userId,
                PetId = petId
            };

            await repo.AddAsync(like);
            await repo.SaveChangesAsync();

           return repo.AllReadonly<Like>(l => l.PetId == petId).Count();
        }
    }
}
