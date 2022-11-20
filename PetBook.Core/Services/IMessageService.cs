using PetBook.Core.Models.Message;

namespace PetBook.Core.Services
{
    public interface IMessageService
    {
       
        public Task<ChatModel> GetCurrentUserMessages(string currentUserId);
        public Task<IEnumerable<MessageModel>> GetMessagesForChat(string currentUserId, string otherUserId);
        
    }
}
