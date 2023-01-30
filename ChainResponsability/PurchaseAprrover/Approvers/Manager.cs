namespace ChainResponsability.PurchaseAprrover
{
    public class Manager : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 10000.0)
            {
                Console.WriteLine($"{GetType().Name} approved request# {purchase.Number}");
            }
            else if (Successor != null)
            {
                Successor.ProcessRequest(purchase);
            }
        }
    }
}
