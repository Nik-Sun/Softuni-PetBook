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


        public override async Task OnConnectedAsync()
        {
            await repo.AddAsync<ActiveConnection>(new ActiveConnection
            {
                UserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier),
                ConnectionId = Context.ConnectionId
            });
            
            await repo.SaveChangesAsync();
            await Groups.AddToGroupAsync(Context.ConnectionId,Context.User.FindFirstValue(ClaimTypes.NameIdentifier));
            await base.OnConnectedAsync();
        }

        public async Task SendMessage(string recipientId, string messageText)
        {
            var currentUserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            
            var message = new Message()
            {
                SenderId = currentUserId,
                RecieverId = recipientId,
                Content = messageText,
                CreatedOn = DateTime.UtcNow
            };
            bool isUserOnline = repo.AllReadonly<ActiveConnection>(ac => ac.UserId == recipientId).Any();
            if (isUserOnline)
            {
                message.IsRead = true;
            }

            string name = Context?.User?.Identity?.Name ?? "";
            var recipientName = await repo.AllReadonly<User>(u => u.Id == recipientId)
                .Select(u => $"{u.FirstName} {u.LastName}")
                .FirstAsync();

            string? senderImageUrl = await repo.AllReadonly<User>(u => u.Id == currentUserId)
                .Include(u => u.Image)
                .Select(u => u.Image.Url)
                .FirstAsync();

            var model = new MessageModel()
            {
                RecipientId = recipientId,
                SenderId = currentUserId,
                SenderName = name,
                RecipientName = recipientName,
                Content = messageText,
                SenderProfileImageUrl = senderImageUrl

            };
            if (Context.i)
            {
                Groups.AddToGroupAsync();
            }
            
            await Clients.Groups(recipientId,currentUserId).SendAsync("ReceiveMessage", model);
            //await Clients.Users(recipientId, currentUserId).SendAsync("ReceiveMessage", model);
            await repo.AddAsync(message);
            await repo.SaveChangesAsync();
        }


        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var connection = await repo.All<ActiveConnection>(c => c.ConnectionId == Context.ConnectionId)
                .FirstOrDefaultAsync();
            await repo.DeleteAsync<ActiveConnection>(connection.Id);
            await repo.SaveChangesAsync();
            await base.OnDisconnectedAsync(exception);
        }
    }
}
