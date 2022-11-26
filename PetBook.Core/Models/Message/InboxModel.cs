namespace PetBook.Core.Models.Message
{
    public class InboxModel
    {
        public InboxModel()
        {
            Users = new List<InboxUserModel>();
        }
        public string CurrentUserId { get; set; }
        public ICollection<InboxUserModel> Users { get; set; }
        

    }
}
