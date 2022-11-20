using Microsoft.EntityFrameworkCore;
using PetBook.Core.Models.Message;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;

namespace PetBook.Core.Services
{
    public class MessageService : IMessageService
    {
        private readonly IRepository repo;

        public MessageService(IRepository _repo)
        {
            this.repo = _repo;
        }

        public async Task<ChatModel> GetCurrentUserMessages(string currentUserId)
        {
            var messages = await repo.AllReadonly<Message>(m => (m.RecieverId == currentUserId) || ( m.SenderId == currentUserId))
                .Include(m => m.Sender)
                .Include(m => m.Reciever)
                .ToListAsync();

            var model = new ChatModel();
            model.CurrentUserId = currentUserId;
            foreach (var message in messages)
            {
                model.Users.Add(message.SenderId, $"{message.Sender.FirstName} {message.Sender.LastName}");
                model.Users.Add(message.RecieverId, $"{message.Reciever.FirstName} {message.Reciever.LastName}");
            }


            return model;


        }

        public async Task<IEnumerable<MessageModel>> GetMessagesForChat(string currentUserId, string otherUserId)
        {
            var messages = await repo.AllReadonly<Message>(m => 
            (m.RecieverId == currentUserId && m.SenderId == otherUserId) 
            || (m.SenderId==currentUserId && m.RecieverId == otherUserId))
                 .Include(m => m.Sender)
                 .Include(m => m.Reciever)
                 .ToListAsync();
            var model = messages.Select(m => new MessageModel()
            {
                Content = m.Content,
                SenderName = m.Sender.FirstName,
                RecipientName = m.Reciever.FirstName,
                SenderId = m.SenderId,
                RecipientId = m.RecieverId
               
            });

            return model;
        }


        //public async Task SendMessage(MessageModel model)
        //{
        //    var recipientId = model.RecipientId;
        //    var user = await repo.GetByIdAsync<User>(recipientId);

        //    if (user != null)
        //    {
        //        user.Messages.Add(new Message()
        //        {
        //            SenderId = model.SenderId,
        //            Content = model.Content,
        //            IsRead = false,
        //            Title = model.Title,
        //            CreatedOn = DateTime.UtcNow,
        //        });
        //        await repo.SaveChangesAsync();
        //    }

        //}
    }

}