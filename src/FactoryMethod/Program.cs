using FactoryMethod.Payments;

namespace FactoryMethod;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        ProcessPayment(PaymentServiceFactory.ServiceAvailable.Italian,
                       "jandersoncampelo@gmail.com",
                       199.99m,
                       EnumChargingOptions.CreditCard);
    }

    private static void ProcessPayment(PaymentServiceFactory.ServiceAvailable serviceToCharge,
                                       string email,
                                       decimal money,
                                       EnumChargingOptions option)
    {
        PaymentServiceFactory factory = new();
        //var paymentService = new PaymentServiceFactory().GetPaymentService(service);
        var service = factory.GetPaymentService(serviceToCharge);
        service.EmailToCharge = email;
        service.MoneyToCharge = money;
        service.OptionToCharge = option;
        service.ProcessCharging();
    }
}