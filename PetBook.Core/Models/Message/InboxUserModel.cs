using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.Message
{
    public class InboxUserModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string UserProfilePictureUrl { get; set; }
        public int UnreadMessagesFromUser { get; set; }
    }
}
