namespace Mediator.AirTrafficControl
{
    public class Airplane
    {
        private readonly IAirTrafficControl _atc;
        public string Name { get; set; }

        public Airplane(IAirTrafficControl atc, string name)
        {
            _atc = atc;
            Name = name;
            _atc.RegisterPlane(this);
        }
        
        public void SendWarning(string message)
        {
            Console.WriteLine($"{Name} send warning: {message}");
            _atc.SendWarning(this, message);
        }

        public void SendClearance()
        {
            Console.WriteLine($"{Name} send clearance");
            _atc.SendClearance(this);
        }

        public void ReceiveClearance()
        {
            Console.WriteLine($"{Name} received clearance to land.");
        }

        public void ReceiveWarning(string message)
        {
            Console.WriteLine($"{Name} received warning: {message}");
        }
    }
}
