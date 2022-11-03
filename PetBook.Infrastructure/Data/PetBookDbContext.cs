using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Infrastructure.Data.Configuration;
using PetBook.Infrastructure.Data.Models;

namespace PetBook.Infrastructure.Data
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

            builder.ApplyConfiguration(new BreedConfiguration());

            builder.ApplyConfiguration(new CityConfiguration());

            base.OnModelCreating(builder);
        }

       

        
    }
}
