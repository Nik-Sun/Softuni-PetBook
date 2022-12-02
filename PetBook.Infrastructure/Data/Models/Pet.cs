using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static PetBook.Infrastructure.Data.DataConstants.PetConstants;

namespace PetBook.Infrastructure.Data.Models
{
    public class Pet
    {

        public Pet()
        {
            Images = new List<Image>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public double Weight { get; set; }

        [Required]
        public double Height { get; set; }

        public int Age { get; set; }
        [ForeignKey(nameof(Breed))]
        public int BreedId { get; set; }
        [Required]
        public Breed Breed { get; set; }

        [ForeignKey(nameof(Owner))]
        public string OwnerId { get; set; }

        [Required]
        public User Owner { get; set; }

        public bool IsMale { get; set; }

        public ICollection<Image> Images { get; set; }

        public ICollection<Like> LikedBy { get; set; }
    }
}
