using Mediator.ChatRoom;

IMediator mediator = new ChatRoom();
var user1 = new User(mediator, "User 1");
var user2 = new User(mediator, "User 2");
var user3 = new User(mediator, "User 3");

user1.Send("Hello World!");
user2.Send("Hello!");
user3.Send("Hello All!");