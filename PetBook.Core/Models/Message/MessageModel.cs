using System.ComponentModel.DataAnnotations;

namespace PetBook.Core.Models.Message
{
    public class MessageModel
    {

        public string Content { get; set; }
        public string SenderName { get; set; }
        public string SenderId { get; set; }
        public string RecipientName { get; set; }
        public string RecipientId { get; set; }



    }
}
