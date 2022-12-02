using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
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

          

            builder.Entity<Message>()
                .HasOne(m => m.Sender)
                .WithMany(u => u.SentMessages)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Message>()
               .HasOne(m => m.Reciever)
               .WithMany(u => u.RecievedMessages)
               .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Image>()
                 .HasOne<User>()
                 .WithOne(u => u.Image);

            builder.Entity<Image>()
                 .HasOne<Pet>()
                 .WithMany(p => p.Images);

            builder.Entity<User>()
                .HasOne(u => u.MyGroup)
                .WithOne(g => g.Author);

            builder.Entity<User>()
                .HasOne(u => u.MemberInGroup)
                .WithOne(g => g.SecondMember)
                .IsRequired(false);

            builder.Entity<User>()
                .HasMany(u => u.LikedPets)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Pet>()
                .HasMany(p => p.LikedBy)
                .WithOne(l => l.Pet)
                .HasForeignKey(p => p.PetId)
                .OnDelete(DeleteBehavior.NoAction); 

            builder.Entity<Like>()
                .HasKey(l => l.Id);

            builder.ApplyConfiguration(new BreedConfiguration());

            builder.ApplyConfiguration(new CityConfiguration());

            base.OnModelCreating(builder);
        }

       

        
    }
}
