﻿using PetBook.Core.Data.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Models.User
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; } = null!;

        [Compare(nameof(Password))]
        [Required(AllowEmptyStrings = false)]
        public string ConfirmPassword { get; set; } = null!;

        [Required]
        public int CityId { get; set; }

        public ICollection<CityDTO>? Cities { get; set; }

        [MaxLength(100)]
        public string Address { get; set; } = null!;
    }
}
