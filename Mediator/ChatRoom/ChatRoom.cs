namespace Mediator.ChatRoom
{
    public class ChatRoom : IMediator
    {
        private readonly List<User> _users = new List<User>();

        public void Register(User user)
        {
            _users.Add(user);
        }

        public void Send(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.Receive(message);
                }
            }
        }
    }
}
