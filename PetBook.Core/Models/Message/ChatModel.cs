namespace PetBook.Core.Models.Message
{
    public class ChatModel
    {
        public ChatModel()
        {
            Users = new Dictionary<string, string>();
        }
        public string CurrentUserId { get; set; }
        public IDictionary<string,string> Users { get; set; }

    }
}
