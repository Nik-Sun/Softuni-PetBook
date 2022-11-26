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

        public async Task<InboxModel> GetCurrentUserMessages(string currentUserId)
        {
            var recievedMessages = await repo.AllReadonly<Message>(m => (m.RecieverId == currentUserId))
                .Include(m => m.Sender)
                .ThenInclude(u=> u.Image)
                .ToListAsync();

            

            var sentMessages = await repo.AllReadonly<Message>(m => (m.SenderId == currentUserId))
                .Include(m => m.Reciever)
                .ThenInclude(u => u.Image)
                .ToListAsync();

            var model = new InboxModel();
            model.CurrentUserId = currentUserId;
            foreach (var message in recievedMessages.DistinctBy(m => m.SenderId))
            {

                model.Users.Add(new InboxUserModel()
                {
                    UnreadMessagesFromUser = repo.AllReadonly<Message>
                    (m => m.SenderId == message.SenderId)
                    .Where(m => m.IsRead == false)
                    .Count(),

                    UserId = message.SenderId,
                    UserName = $"{message.Sender.FirstName} {message.Sender.LastName}",
                    UserProfilePictureUrl = message.Sender.Image.Url
                });

           
            }
            foreach (var message in sentMessages.DistinctBy(m => m.RecieverId))
            {
                model.Users.Add(new InboxUserModel()
                {
                    UserId = message.RecieverId,
                    UserName = $"{message.Reciever.FirstName} {message.Reciever.LastName}",
                    UserProfilePictureUrl = message.Reciever.Image.Url
                });
            }

            model.Users = model.Users.DistinctBy(u => u.UserId).ToList();
            

            return model;


        }

        public async Task<ChatModel> GetMessagesForChat(string currentUserId, string otherUserId)
        {
            var messages = await repo.AllReadonly<Message>(m =>
            (m.RecieverId == currentUserId && m.SenderId == otherUserId)
            || (m.SenderId == currentUserId && m.RecieverId == otherUserId))
                 .Include(m => m.Sender)
                 .ThenInclude(s => s.Image)
                 .Include(m => m.Reciever)
                 .ThenInclude(r => r.Image)
                 .ToListAsync();
            var model = new ChatModel()
            {
                SenderId = currentUserId,
                RecipientId = otherUserId
            };
           

            foreach (var msg in messages)
            {
                if (msg.SenderId == currentUserId)
                {
                    model.SentMessages.Add(new MessageModel()
                    {
                        SenderId = msg.SenderId,
                        RecipientId = msg.RecieverId,
                        SenderName = msg.Sender.FirstName,
                        RecipientName = msg.Reciever.FirstName,
                        Content = msg.Content,
                        CreatedOn = msg.CreatedOn,
                        SenderProfileImageUrl = msg.Sender.Image.Url,
                        RecipientProfileImageUrl = msg.Reciever.Image.Url
                    });
                }
                else
                {
                    model.RecievedMessages.Add(new MessageModel()
                    {
                        SenderId = msg.SenderId,
                        RecipientId = msg.RecieverId,
                        SenderName = msg.Sender.FirstName,
                        RecipientName = msg.Reciever.FirstName,
                        Content = msg.Content,
                        CreatedOn = msg.CreatedOn,
                        SenderProfileImageUrl = msg.Sender.Image.Url,
                        RecipientProfileImageUrl = msg.Reciever.Image.Url
                    });
                }
            }
            //{
            //    CreatedOn = m.CreatedOn,
            //    Content = m.Content,
            //    SenderName = m.Sender.FirstName,
            //    RecipientName = m.Reciever.FirstName,
            //    SenderId = m.SenderId,
            //    RecipientId = m.RecieverId,
            //    SenderProfileImageUrl = m.Sender.Image.Url,
            //    RecipientProfileImageUrl = m.Reciever.Image.Url

            //});

            //if (model.SentMessages.Any() || model.RecievedMessages.Any())
            //{
            //    await MarkMessagesAsRead(currentUserId);
            //    return model;
            //}

            //var senderName = await repo.AllReadonly<User>(u => u.Id == currentUserId)
            //    .Select(u => u.FirstName + " " + u.LastName)
            //    .FirstOrDefaultAsync();
            //var recipientName = await repo.AllReadonly<User>(u => u.Id == otherUserId)
            //   .Select(u => u.FirstName + " " + u.LastName)
            //   .FirstOrDefaultAsync();

            //var otherModel = model.ToList();
            //otherModel.Add(new MessageModel()
            //{
            //    CreatedOn = DateTime.UtcNow,
            //    SenderName = senderName,
            //    RecipientName = recipientName,
            //    SenderId = currentUserId,
            //    RecipientId = otherUserId
            //});
            return model;
        }


        
        private async Task MarkMessagesAsRead(string currentUserId)
        {
            var messages = await repo.All<Message>(m => m.RecieverId == currentUserId)
                .ToListAsync();
            foreach (var msg in messages)
            {
                msg.IsRead = true;
            }
            await repo.SaveChangesAsync();
        }
      
    }

}
