using System.ComponentModel.DataAnnotations;
using static PetBook.Infrastructure.Data.DataConstants.BreedConstants;

namespace PetBook.Infrastructure.Data.Models
{
    public class Breed
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
        
    }
}
