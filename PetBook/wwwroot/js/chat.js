
"use strict";

let connection = new signalR.HubConnectionBuilder().withUrl("/Message/Chats").build();
let ownerId;
//Disable the send button until connection is established.
document.getElementById("sendBtn").disabled = true;
let recipientId = document.getElementById('recipient-id').value;
let senderId = document.getElementById('senderId').value;
let chatWindowEl = document.querySelector('.chat-messages');
let chatWindowHeight = chatWindowEl.scrollHeight





connection.on("ReceiveMessage", function (message) {
    console.log('ReceiveMessage invoked')
    let date = new Date(message.createdOn);
    console.log(date);
    let messageHtml =
        ` <div>
                                <img src="${message.senderProfileImageUrl}" class="rounded-circle mr-1" alt="${message.senderName}" width="40" height="40">
                                <div class="text-muted small text-nowrap mt-2">${date.toLocaleTimeString(['en-US'], {hour:'numeric',minute:'2-digit'})}</div>
                            </div>
                            <div class="flex-shrink-1 bg-light rounded py-2 px-3 ml-3">
                                <div class="font-weight-bold mb-1">${message.senderName}</div>
                                ${message.content}
                            </div>`;

    let element = document.createElement('div');
    let isRead = false;
    //TODO: Sanitize HTML

    if (message.senderId == senderId) {
        element.classList.add('chat-message-right', 'pb-4');

    }
    else {
        element.classList.add('chat-message-left', 'pb-4');
        isRead = true
        connection.invoke("UpdateMessageStatus", message.id, isRead)
    }


    element.innerHTML = messageHtml;
    console.log(message);


   
    chatWindowEl.appendChild(element);
    chatWindowEl.scrollTo(0, chatWindowHeight)

   



});

connection.start().then(function () {
    connection.invoke("CreateGroup", senderId, recipientId);
    document.getElementById("sendBtn").disabled = false;
    chatWindowEl.scrollTo(0, chatWindowHeight)
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendBtn").addEventListener("click", function (event) {
    console.log(connection)
    let recipientId = document.getElementById('recipient-id').value;
    let message = document.getElementById('messageBox');
    console.log(recipientId, message)
    connection.invoke("SendMessage", recipientId, message.value).catch(e => console.log(e))

    event.preventDefault();
    message.value = '';

});