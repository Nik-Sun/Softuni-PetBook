using Microsoft.AspNetCore.Http;
using PetBook.Core.Data.Models.DTOs;
using System.ComponentModel.DataAnnotations;

namespace PetBook.Core.Models.User
{
    public class UserFormViewModel
    {
        [Required]
        public string Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "must be between 2 and 50 symbols.")]
        public string FirstName { get; set; } = null!;

        [Required(AllowEmptyStrings = false, ErrorMessage = "field is required.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "must be between 2 and 50 symbols.")]
        public string LastName { get; set; } = null!;

        [EmailAddress]
        [Required(AllowEmptyStrings = false, ErrorMessage = "field is required.")]
        public string Email { get; set; } = null!;

        [Required]
        public int CityId { get; set; }

        public ICollection<CityDTO>? Cities { get; set; }

        [MaxLength(100)]
        public string Address { get; set; } = null!;

        public IFormFile? ProfilePicture { get; set; }
        public string? ProfilePictureUrl { get; set; }

        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
