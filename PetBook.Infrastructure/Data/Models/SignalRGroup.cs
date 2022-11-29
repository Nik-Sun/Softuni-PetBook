using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetBook.Infrastructure.Data.Models
{
    public class SignalRGroup
    {
        public SignalRGroup()
        {
            ConnectionIds = new HashSet<ConnectionId>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
       
        public string AuthorId { get; set; }

        public User Author { get; set; }

        
        public string? SecondMemberId { get; set; }

        public User? SecondMember { get; set; }

        public ICollection<ConnectionId> ConnectionIds { get; set; }

    }
}
