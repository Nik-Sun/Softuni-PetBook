using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Infrastructure.Data.Models;

namespace PetBook.Infrastructure.Data.Configuration
{
    internal class BreedConfiguration : IEntityTypeConfiguration<Breed>
    {
        public void Configure(EntityTypeBuilder<Breed> builder)
        {
            builder.HasData(SeedDatabaseWithBreeds());
        }

        private Breed[] SeedDatabaseWithBreeds()
        {
            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("x-api-key", "live_1CB0e2r4Z06ESv3Ey0oFmkckviZ6cAVwP3Eu89hVhHl1cogKV22VHh9wKqve2zmr");
            var breedsJson = client.GetStringAsync("https://api.thedogapi.com/v1/breeds").GetAwaiter().GetResult();
            var breeds = JsonConvert.DeserializeObject<BreedDto[]>(breedsJson);

            return breeds.Select(b => new Breed()
            {
                Name = b.Name,
                Id = b.Id,
            }).ToArray();
        }
    }
}
