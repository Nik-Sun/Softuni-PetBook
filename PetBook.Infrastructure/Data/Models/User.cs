using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static PetBook.Infrastructure.Data.DataConstants.UserConstants;

namespace PetBook.Infrastructure.Data.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            Pets = new List<Pet>();
           
        }
        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }

        [Required]
        [MaxLength(AddressMaxLength)]
        public Address Address { get; set; } = null!;

        public ICollection<Pet> Pets { get; set; }
       
       public ICollection<Message> SentMessages { get; set; }
       public ICollection<Message> RecievedMessages { get; set; }
       
        public int? ImageId { get; set; }

        public Image? Image { get; set; }
    }
}
