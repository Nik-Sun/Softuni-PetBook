using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using PetBook.Core.Data.Models.DTOs;
using PetBook.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Infrastructure.Data.Configuration
{
    internal class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasData(SeedDatabaseWithCities());
        }

        private City[] SeedDatabaseWithCities()
        {

            var citiesJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}/../../../../PetBook.Infrastructure/Data/JSON/bg.json");
            var citiesDto = JsonConvert.DeserializeObject<CityDTO[]>(citiesJson);
            List<City> cities = new List<City>();
            for (int i = 1; i <= citiesDto.Length; i++)
            {
                cities.Add(new City()
                {
                    Id = i,
                    Name = citiesDto[i - 1].Name,
                });
            }
            return cities.ToArray();
        }
    }
}
