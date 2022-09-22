"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

document.getElementById("sendButton").disabled = true;


changeUser()
connection.on("ReceiveMessage", function (message) {
    let msg =  ` <div class="message">
                        <p class="text"> ${message}</p>
                    </div>`
    $(".messages-chat").append(msg);
});
connection.on("Connected", function (username) {
    let id = "#" + username;
    $(id).removeClass("offline");
    $(id).addClass("online");
}) 
connection.on("DisConnected", function (username) {
    let id = "#" + username;
    $(id).removeClass("online");
    $(id).addClass("offline");
})
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

$(".discussion").not(".search").click(function () {
    $(".discussion").removeClass("message-active");
    $(this).addClass("message-active");
    $("#sendButton").attr("username", $(this).find(".status").attr("id"))
    
})

$("#sendButton").click(function () {
    let message = $("#messageInput").val();
    let userName = $(this).attr("username");
    connection.invoke("SendMessage", userName, message).then(function () {
        $("#messageInput").val("");
    }).catch(function (err) {
        return console.error(err.toString());
    });
})
function changeUser() {
    $(".discussion").eq(1).addClass("message-active");
    $("#sendButton").attr("username", $(".discussion .status").attr("id"))

}
