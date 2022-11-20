using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Infrastructure.Data.Models
{
    public class Chat
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey(nameof(Author))]
        public string AuthorId { get; set; }
        public User Author { get; set; }

        [Required]
        [ForeignKey(nameof(Recipient))]
        public string RecipientId { get; set; }
        public User Recipient { get; set; }
        public DateTime CreatedOn { get; set; }

        public ICollection<Message> Messages { get; set; }
    }
}
