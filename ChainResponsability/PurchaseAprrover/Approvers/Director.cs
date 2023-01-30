namespace ChainResponsability.PurchaseAprrover
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
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
