namespace FactoryMethod.Transports;

public class ShipFactory : TransportFactory
{
    public override ITransport CreateTransport()
    {
        return new Ship();
    }
}