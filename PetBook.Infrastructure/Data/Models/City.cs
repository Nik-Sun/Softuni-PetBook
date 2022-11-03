using System.ComponentModel.DataAnnotations;
using static PetBook.Infrastructure.Data.DataConstants.CityConstants;

namespace PetBook.Infrastructure.Data.Models
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
