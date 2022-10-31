using System.ComponentModel.DataAnnotations;
using static PetBook.Core.Data.DataConstants.CityConstants;

namespace PetBook.Core.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
