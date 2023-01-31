namespace Mediator.AirTrafficControl
{
    public interface IAirTrafficControl
    {
        void RegisterPlane(Airplane airplane);
        void SendWarning(Airplane sender, string message);
        void SendClearance(Airplane sender);
    }
}
