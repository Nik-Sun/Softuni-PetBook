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
            var recievedMessages = await repo.AllReadonly<Message>(m => (m.RecieverId == currentUserId))
                .Include(m => m.Sender)
                .ToListAsync();

            var sentMessages = await repo.AllReadonly<Message>(m => (m.SenderId == currentUserId))
                .Include(m => m.Reciever)
                .ToListAsync();

            var model = new ChatModel();
            model.CurrentUserId = currentUserId;
            foreach (var message in recievedMessages.DistinctBy(m => m.SenderId))
            {

                model.Users.Add(new ChatUsersModel()
                {
                    UserId = message.SenderId,
                    UserName = $"{message.Sender.FirstName} {message.Sender.LastName}"
                });

                //model.Users.Add(message.SenderId, $"{message.Sender.FirstName} {message.Sender.LastName}");
                //model.Users.Add(message.RecieverId, $"{message.Reciever.FirstName} {message.Reciever.LastName}");
            }
            foreach (var message in sentMessages.DistinctBy(m => m.RecieverId))
            {

                model.Users.Add(new ChatUsersModel()
                {
                    UserId = message.RecieverId,
                    UserName = $"{message.Reciever.FirstName} {message.Reciever.LastName}"
                });
            }

            model.Users = model.Users.DistinctBy(u => u.UserId).ToList();
            return model;


        }

        public async Task<IEnumerable<MessageModel>> GetMessagesForChat(string currentUserId, string otherUserId)
        {
            var messages = await repo.AllReadonly<Message>(m =>
            (m.RecieverId == currentUserId && m.SenderId == otherUserId)
            || (m.SenderId == currentUserId && m.RecieverId == otherUserId))
                 .Include(m => m.Sender)
                 .Include(m => m.Reciever)
                 .ToListAsync();
            var model = messages.Select(m => new MessageModel()
            {
                CreatedOn = m.CreatedOn,
                Content = m.Content,
                SenderName = m.Sender.FirstName,
                RecipientName = m.Reciever.FirstName,
                SenderId = m.SenderId,
                RecipientId = m.RecieverId

            });
            if (model.Any())
            {
                return model;
            }

            var senderName = await repo.AllReadonly<User>(u => u.Id == currentUserId)
                .Select(u => u.FirstName + " " + u.LastName)
                .FirstOrDefaultAsync();
            var recipientName = await repo.AllReadonly<User>(u => u.Id == otherUserId)
               .Select(u => u.FirstName + " " + u.LastName)
               .FirstOrDefaultAsync();

            var otherModel = model.ToList();
            otherModel.Add(new MessageModel()
            {
                CreatedOn = DateTime.UtcNow,
                SenderName = senderName,
                RecipientName = recipientName,
                SenderId = currentUserId,
                RecipientId = otherUserId
            });
            return otherModel;
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
