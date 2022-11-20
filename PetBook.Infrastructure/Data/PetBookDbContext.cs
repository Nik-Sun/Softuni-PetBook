﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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

            //builder.Entity<User>()
            //    .HasMany(u => u.Chats)
            //    .WithOne(c => c.Author)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.Entity<Chat>()
            //    .HasOne(u => u.Recipient)
            //    .WithMany(c => c.Chats)
            //    .OnDelete(DeleteBehavior.NoAction);

            builder.ApplyConfiguration(new BreedConfiguration());

            builder.ApplyConfiguration(new CityConfiguration());

            base.OnModelCreating(builder);
        }

       

        
    }
}
