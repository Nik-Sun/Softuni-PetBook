using Microsoft.AspNetCore.Http;
using PetBook.Core.CustomValidation;
using System.ComponentModel.DataAnnotations;

using static PetBook.Infrastructure.Data.DataConstants.PetConstants;
namespace PetBook.Core.Models.Pets
{
    public class PetModel
    {

        public PetModel()
        {
            Images = new List<IFormFile>();
        }

        [Required(AllowEmptyStrings = false)]
        [StringLength(NameMaxLength, MinimumLength = 2)]

        public string Name { get; set; } = null!;

        [Required(AllowEmptyStrings = false)]
        [StringLength(DescriptionMaxLength, MinimumLength = 10)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(1.0, 120.0)]
        public double Weight { get; set; }

        [Required]
        [Range(5, 115.0)]
        public double Height { get; set; }

        [Range(1, 25)]
        public int Age { get; set; }

        [Required]
        public bool IsMale { get; set; }

        [AllowedExtensions(".jpg",".jpeg")]
        [MaxFileSize(MaxPetImageFileSize)]
        public ICollection<IFormFile> Images { get; set; }
    }
}
