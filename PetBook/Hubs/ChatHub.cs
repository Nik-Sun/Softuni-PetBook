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

        public async Task SendMessage(string recipientId,string messageText)
        {
            var currentUserId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var message = new Message()
            {
                SenderId = currentUserId,
                RecieverId = recipientId,
                Content = messageText,
                CreatedOn = DateTime.UtcNow,
                IsRead = false

            };
            string name = Context?.User?.Identity?.Name ?? "";
            string? recipientName = await repo.AllReadonly<User>(u => u.Id == recipientId)
                .Select(u => $"{u.FirstName} {u.LastName}")
                .FirstOrDefaultAsync();
            var model = new MessageModel()
            {
                RecipientId = recipientId,
                SenderId = currentUserId,
                SenderName = name,
                RecipientName = recipientName,
                Content = messageText,
            };
            await Clients.Users(recipientId,currentUserId).SendAsync("ReceiveMessage", model);
        }
    }
}
