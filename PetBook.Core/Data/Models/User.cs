using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static PetBook.Core.Data.DataConstants.UserConstants;

namespace PetBook.Core.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        [Required]
        public Address Address { get; set; } = null!;

        public ICollection<Pet> Pets { get; set; }
        [Required]
        public Image Image { get; set; }
    }
}
