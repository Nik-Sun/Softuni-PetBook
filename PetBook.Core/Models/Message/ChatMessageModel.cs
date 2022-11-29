using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetBook.Core.Models.Message
{
    public class ChatMessageModel
    {
        public string AuthorId { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
