namespace FactoryMethod.Transports;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by truck...");
    }
}