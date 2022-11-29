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
            Messages = new List<ChatMessageModel>();
            
        }
        public ICollection<ChatMessageModel> Messages  { get; set; }
        
        public string CurrentUserId { get; set; }
        public string CurrentUserName { get; set; }
        public string RecipientId { get; set; }
        public string RecipientName { get; set; }
        public string CurrentUserProfileImageUrl { get; set; }
        public string RecipientProfileImageUrl { get; set; }
    }
}
