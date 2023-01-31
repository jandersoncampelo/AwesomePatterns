using Mediator.ChatRoom;
using Xunit;

namespace MediatorTests
{
    public class ChatRoomTest
    {
        [Fact]
        public void TestUserReceivesMessage()
        {
            IMediator mediator = new ChatRoom();
            User user1 = new User(mediator, "User 1");
            User user2 = new User(mediator, "User 2");

            user1.Send("Hi all!");
            string message = "Hello!";
            user2.Send(message);

            Assert.Contains(message, user1.ReceivedMessages);
        }

        private class User : IMediatorUser
        {
            private readonly IMediator _mediator;
            public string Name { get; set; }
            public List<string> ReceivedMessages { get; } = new List<string>();

            public User(IMediator mediator, string name)
            {
                _mediator = mediator;
                Name = name;
                _mediator.Register(this);
            }

            public void Send(string message)
            {
                _mediator.Send(message, this);
            }

            public void Receive(string message)
            {
                ReceivedMessages.Add(message);
            }
        }

        private interface IMediatorUser : IMediator
        {
            List<string> ReceivedMessages { get; }
            void Receive(string message);
        }
    }

}