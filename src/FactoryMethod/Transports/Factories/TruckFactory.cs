namespace FactoryMethod.Transports;

public class TruckFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}