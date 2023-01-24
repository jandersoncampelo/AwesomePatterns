namespace FactoryMethod.Transports.Factories;

public class TruckFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Truck();
    }
}