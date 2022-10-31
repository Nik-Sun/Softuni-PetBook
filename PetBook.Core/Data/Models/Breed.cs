using System.ComponentModel.DataAnnotations;
using static PetBook.Core.Data.DataConstants.BreedConstants;

namespace PetBook.Core.Data.Models
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
