namespace PetBook.Core.Models.Message
{
    public class ChatModel
    {
        public ChatModel()
        {
            Users = new List<ChatUsersModel>();
        }
        public string CurrentUserId { get; set; }
        public ICollection<ChatUsersModel> Users { get; set; }

    }
}
