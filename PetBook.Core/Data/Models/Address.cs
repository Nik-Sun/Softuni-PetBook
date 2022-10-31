﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static PetBook.Core.Data.DataConstants.AddressConnstants;
namespace PetBook.Core.Data.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(AddressTextMaxLength)]
        public string AddressText { get; set; } = null!;

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        [Required]
        public City City { get; set; }
    }
}
