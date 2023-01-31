namespace Mediator.AirTrafficControl
{
    public class AirTrafficControl : IAirTrafficControl
    {
        private readonly List<Airplane> _planes = new List<Airplane>();
        
        public void RegisterPlane(Airplane airplane)
        {
            _planes.Add(airplane);
        }

        public void SendClearance(Airplane sender)
        {
            foreach (var plane in _planes)
            {
                if (plane != sender)
                {
                    plane.ReceiveClearance();
                }
            }
        }

        public void SendWarning(Airplane sender, string message)
        {
            foreach (var plane in _planes)
            {
                if (plane != sender)
                {
                    plane.ReceiveWarning(message);
                }
            }
        }
    }
}
