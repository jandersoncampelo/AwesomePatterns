namespace ChainResponsability.PurchaseAprrover
{
    public class Purchase
    {
        private int _number;
        private double _amount;
        private string _purpose;

        public Purchase(int number, double amount, string purpose)
        {
            _number = number;
            _amount = amount;
            _purpose = purpose;
        }

        public int Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public double Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }
    }
}
