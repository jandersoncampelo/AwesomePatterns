using FactoryMethod.Transports;
using Xunit;

namespace FactoryMethodTests;

public class TransportFactoryTests
{
    [Theory]
    [InlineData("Truck")]
    [InlineData("Ship")]
    public void CreateTransport_ShouldReturnCorrectTransport(string transportType)
    {
        // Arrange
        TransportFactory factory;
        if (transportType == "Truck")
        {
            factory = new TruckFactory();
        }
        else
        {
            factory = new ShipFactory();
        }
        // Act
        var transport = factory.CreateTransport();

        // Assert
        if (transportType == "Truck")
        {
            Assert.IsType<Truck>(transport);
        }
        else
        {
            Assert.IsType<Ship>(transport);
        }
    }
}
