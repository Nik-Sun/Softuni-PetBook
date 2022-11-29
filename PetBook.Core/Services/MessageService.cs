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
                .ThenInclude(u => u.Image)
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

        public async Task<ChatModel> GetMessagesForChat(string currentUserId, string recipientId)
        {
            var messages = await repo.AllReadonly<Message>(m =>
            (m.RecieverId == currentUserId && m.SenderId == recipientId)
            || (m.SenderId == currentUserId && m.RecieverId == recipientId))
                 .OrderBy(m => m.CreatedOn)
                 .Select(m => new ChatMessageModel()
                 {
                     Content = m.Content,
                     CreatedOn = m.CreatedOn,
                     AuthorId = m.SenderId
                 })
                 .ToListAsync();

            var currentUser = await repo.AllReadonly<User>(u => u.Id == currentUserId)
                .Include(u => u.Image)
                .FirstAsync();
            var recipient = await repo.AllReadonly<User>(u => u.Id == recipientId)
                .Include(u => u.Image)
               .FirstAsync();
            var model = new ChatModel()
            {
                CurrentUserId = currentUserId,
                RecipientId = recipientId,
                CurrentUserProfileImageUrl = currentUser.Image.Url,
                RecipientProfileImageUrl = recipient.Image.Url,
                CurrentUserName = currentUser.UserName,
                RecipientName = recipient.UserName,
                Messages = messages,

            };



            await MarkMessagesAsRead(currentUserId,recipientId);
            return model;
        }



        private async Task MarkMessagesAsRead(string currentUserId,string recipientId)
        {
            var messages = await repo.All<Message>(m => m.RecieverId == currentUserId && m.SenderId == recipientId)
                .ToListAsync();
            foreach (var msg in messages)
            {
                msg.IsRead = true;
            }
            await repo.SaveChangesAsync();
        }
      
    }

}
