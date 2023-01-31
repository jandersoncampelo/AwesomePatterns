namespace Mediator.ChatRoom
{
    public interface IMediator
    {
        void Register(User user);
        void Send(string message, User sender);
    }
}
