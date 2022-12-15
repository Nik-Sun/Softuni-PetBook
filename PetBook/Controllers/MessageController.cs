using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetBook.Core.Services;
using PetBook.Infrastructure.Data.Models;
using System.Security.Claims;

namespace PetBook.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly IMessageService messageService;


        public MessageController(UserManager<User> _userManager
            , IMessageService _messageService)
        {
            userManager = _userManager;
            messageService = _messageService;

        }

     
       

        [HttpGet]
        public async Task<IActionResult> Inbox()
        {
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await messageService.GetCurrentUserMessages(currentUserId);
            return View(model);
        }

        public async Task<IActionResult> Chat(string recipientId)
        {
            if (recipientId == null)
            {
                return BadRequest();
            }
            var currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var model = await messageService.GetMessagesForChat(currentUserId,recipientId);
            return View(model);
        }
      
    }
}
