using PetBook.Core.Models.Message;

namespace PetBook.Core.Services
{
    public interface IMessageService
    {
       
        public Task<InboxModel> GetCurrentUserMessages(string currentUserId);
        public Task<ChatModel> GetMessagesForChat(string currentUserId, string otherUserId);
        
    }
}
