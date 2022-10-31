using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using PetBook.Core.Data.Models;
using PetBook.Core.Data.Models.DTOs;

namespace PetBook.Core.Data
{
    public class PetBookDbContext : IdentityDbContext<User>
    {
        public PetBookDbContext(DbContextOptions<PetBookDbContext> options)
            :base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Breed> Breeds { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Pet>()
                .Property(p => p.Height)
                .HasColumnType("decimal(5,2)");

            builder.Entity<Pet>()
               .Property(p => p.Weight)
               .HasColumnType("decimal(5,2)");

            builder.Entity<Breed>()
                .HasData(SeedDatabase());

            base.OnModelCreating(builder);
        }

        private Breed[] SeedDatabase()
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
