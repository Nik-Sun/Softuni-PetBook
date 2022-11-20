using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PetBook.Infrastructure.Data.Models
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }
        public string Content { get; set; }


        [ForeignKey(nameof(Sender))]
        public string SenderId { get; set; }
        public User Sender { get; set; }
        
        [ForeignKey(nameof(Reciever))]
        public string RecieverId { get; set; }
        public User Reciever { get; set; }

        public bool IsRead { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
