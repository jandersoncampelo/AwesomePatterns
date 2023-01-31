namespace Mediator.ChatRoom
{
    public class User
    {
        private readonly IMediator _mediator;
        public string? Name { get; set; }

        public User(IMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
            _mediator.Register(this);
        }

        public void Send(string message)
        {
            Console.WriteLine($"{Name} send message: {message}");
            _mediator.Send(message, this);
        }

        public void Receive(string message)
        {
            Console.WriteLine($"{Name} received message: {message}");
        }
    }
}
