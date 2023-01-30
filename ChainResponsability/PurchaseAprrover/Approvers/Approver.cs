namespace ChainResponsability.PurchaseAprrover
{
    public abstract class Approver
    {
        protected Approver? Successor;

        public abstract void ProcessRequest(Purchase purchase);

        public void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }
    }
}
