using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.Message
{
    public class ChatModel
    {
        public ChatModel()
        {
            SentMessages = new List<MessageModel>();
            RecievedMessages = new List<MessageModel>();
        }
        public ICollection<MessageModel> SentMessages  { get; set; }
        public ICollection<MessageModel> RecievedMessages { get; set; }

        public string SenderId { get; set; }
        public string RecipientId { get; set; }
    }
}
