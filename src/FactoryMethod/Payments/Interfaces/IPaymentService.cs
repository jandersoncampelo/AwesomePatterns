namespace FactoryMethod.Payments;

public interface IPaymentService
{
    /// <summary>
    /// E-mail of the person who will be charged
    /// </summary>
    public string? EmailToCharge { get; set; }
    /// <summary>
    /// Money that will be charged
    /// </summary>
    public decimal MoneyToCharge { get; set; }
    
    /// <summary>
    /// Credit Card or Debit Card
    /// </summary>
    public EnumChargingOptions OptionToCharge { get; set; }

    /// <summary>
    /// Method responsible for process the charging asked
    /// </summary>
    /// <returns></returns>
    public bool ProcessCharging();
}