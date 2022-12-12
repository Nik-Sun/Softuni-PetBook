using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using PetBook.Core.Models.Message;
using PetBook.Core.Repositories;
using PetBook.Infrastructure.Data.Models;
using System.Security.Claims;

namespace PetBook.Hubs
{
    [Authorize]
    public class ChatHub : Hub
    {
        private readonly IRepository repo;

        public ChatHub(IRepository _repo)
        {
            repo = _repo;
        }


       
        public async Task CreateGroup(string currentUserId, string recipientId)
        {
            var group = await repo.All<SignalRGroup>(g => g.AuthorId == recipientId&&g.SecondMemberId == currentUserId)
                .FirstOrDefaultAsync();

            if (group == null)
            {
                group = new SignalRGroup()
                {
                    Name = Guid.NewGuid().ToString(),
                    AuthorId = currentUserId,
                    SecondMemberId = recipientId
                    
                };
                await repo.AddAsync(group);
            }
            else if(group.SecondMemberId != currentUserId)
            {
                group = new SignalRGroup()
                {
                    Name = Guid.NewGuid().ToString(),
                    AuthorId = recipientId,
                    SecondMemberId = currentUserId
                };
                await repo.AddAsync(group);
            }
            group.ConnectionIds.Add(new ConnectionId()
            {
                Value = Context.ConnectionId
            });
         
            await repo.SaveChangesAsync();
        }

        public async Task SendMessage(string recipientId, string messageText)
        {
            var currentUserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            var connectionIds = await repo.All<SignalRGroup>(g => g.AuthorId == recipientId && g.SecondMemberId == currentUserId
            ||  g.AuthorId == currentUserId && g.SecondMemberId == recipientId)
                .SelectMany(g => g.ConnectionIds.Select(id => id.Value))
                .ToListAsync();
              

          

            var message = new Message()
            {
                Id = Guid.NewGuid(),
                SenderId = currentUserId,
                RecieverId = recipientId,
                Content = messageText,
                CreatedOn = DateTime.UtcNow
            };
           

            string name = Context?.User?.Identity?.Name ?? "";

            string? senderImageUrl = await repo.AllReadonly<User>(u => u.Id == currentUserId)
                .Include(u => u.Image)
                .Select(u => u.Image.Url)
                .FirstAsync();

            var model = new MessageModel()
            {
                Id = message.Id.ToString(),
               
                SenderId = currentUserId,
                SenderName = name,
               CreatedOn = message.CreatedOn,
                Content = messageText,
                SenderProfileImageUrl = senderImageUrl
            };

            await SaveMessage(message);
            await Clients.Clients(connectionIds).SendAsync("ReceiveMessage", model);

            
        }


        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var currentUserId = Context.UserIdentifier;
            var groups = await repo.All<SignalRGroup>(g => g.ConnectionIds.Any() == false)
                .ToListAsync();
            repo.DeleteRange(groups);
            
            string connectionId = Context.ConnectionId;
            var connectionIds = await repo.All<ConnectionId>(id => id.Value == connectionId)
                 .ToListAsync();
            repo.DeleteRange<ConnectionId>(connectionIds);
            await repo.SaveChangesAsync();
            

            await base.OnDisconnectedAsync(exception);
        }


        public async Task UpdateMessageStatus(string messageId, bool isRead)
        {
            if (isRead)
            {
                var message = await repo.GetByIdAsync<Message>(new Guid(messageId));
                message.IsRead = isRead;
                await repo.SaveChangesAsync();
            }

        }
        private async Task SaveMessage(Message message)
        {
            await repo.AddAsync(message);
            await repo.SaveChangesAsync();
        }
    }
}
