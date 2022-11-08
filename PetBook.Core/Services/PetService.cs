using PetBook.Core.Data.Models.DTOs;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Services
{
    public class PetService : IPetService
    {
        private readonly IRepository repo;
        public PetService(IRepository _repo)
        {
            repo = _repo;
        }
        public IEnumerable<BreedDto> GetBreeds()
        {
            var breeds = repo.AllReadonly<Breed>()
                .Select(b => new BreedDto()
                {
                    Id = b.Id,
                    Name = b.Name,
                }).ToList();

            return breeds;
        }
    }
}
