
"use strict";

let connection = new signalR.HubConnectionBuilder().withUrl("/Message/Chats").build();
let ownerId;
//Disable the send button until connection is established.
document.getElementById("sendBtn").disabled = true;


connection.on("ReceiveMessage", function (message) {
   
    let recipientId = document.getElementById('recipient-id').value;
    let senderId = document.getElementById('senderId').value;
    let messageHtml;
    let element = document.createElement('div');
    //TODO: Sanitize HTML
    if (message.senderId == senderId) {
        element.classList.add('chat-message-right', 'pb-4');
        messageHtml = ` <div>
                                <img src="${message.senderProfileImageUrl}" class="rounded-circle mr-1" alt="${message.senderName}" width="40" height="40">
                                <div class="text-muted small text-nowrap mt-2">2:34 am</div>
                            </div>
                            <div class="flex-shrink-1 bg-light rounded py-2 px-3 ml-3">
                                <div class="font-weight-bold mb-1">${message.senderName}</div>
                                ${message.content}
                            </div>`
    }
    else {
        element.classList.add('chat-message-left', 'pb-4');
        messageHtml = ` <div>
                                <img src="${message.senderProfileImageUrl}" class="rounded-circle mr-1" alt="${message.senderName}" width="40" height="40">
                                <div class="text-muted small text-nowrap mt-2">2:34 am</div>
                            </div>
                            <div class="flex-shrink-1 bg-light rounded py-2 px-3 ml-3">
                                <div class="font-weight-bold mb-1">${message.senderName}</div>
                                ${message.content}
                            </div>`
    }
    

    
    
    element.innerHTML = messageHtml;
    console.log(message);
   
    
    let chatWindowEl = document.querySelector('.chat-messages');
    let chatWindowHeight = chatWindowEl.scrollHeight
    chatWindowEl.appendChild(element);
    chatWindowEl.scrollTo(0, chatWindowHeight)

});

connection.start().then(function () {
    document.getElementById("sendBtn").disabled = false;
   
    
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendBtn").addEventListener("click", function (event) {
    let recipientId = document.getElementById('recipient-id').value;
    let message = document.getElementById('messageBox');
    console.log(recipientId,message)
    connection.invoke("SendMessage",recipientId,message.value).catch(e => console.log(e))
   
    event.preventDefault();
    message.value = '';
  
});