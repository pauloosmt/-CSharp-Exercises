using System.Globalization;

namespace Exercicio031
{
    class BankAccount
    {
        public int Number { get; private set; }
        private string _name;
        public double Balance { get; private set; }

        public BankAccount( int number,string name)
        {
            Number = number;
            _name = name;
            
        }

        public BankAccount (int number, string name, double deposit) : this(number, name)
        {
            Deposit(deposit);
        }

        public void SetNumber(int number)
        {
            Number = number;
        }

       public string Name
        {
            get { return _name; }
            set
            {
                if (value != null)
                {
                    _name = value;
                }
            }
        }

        public void Deposit(double value)
        {
            Balance += value;
        }

        public void WithDraw(double value)
        {
            Balance -= value + 5.0;
        }

        public override string ToString()
        {
            return ($"Account: {Number}, Holder: {_name}, Balance: R${Balance.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        

    }
}
