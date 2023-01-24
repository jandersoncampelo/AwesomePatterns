namespace FactoryMethod.Payments;

public class PaymentServiceFactory
{
    public enum ServiceAvailable
    {
        Italian = 0,
        Brazilian
    }

    public IPaymentService GetPaymentService(ServiceAvailable service)
    {
        switch (service)
        {
            case ServiceAvailable.Italian:
                return new ItalianPaymentService();
            case ServiceAvailable.Brazilian:
                return new BrazilianPaymentService();
            default:
                return new ItalianPaymentService();
        }
    }
}