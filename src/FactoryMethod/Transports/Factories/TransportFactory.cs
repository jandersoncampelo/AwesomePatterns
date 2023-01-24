namespace FactoryMethod.Transports;

public abstract class TransportFactory
{
    public abstract ITransport CreateTransport();
}