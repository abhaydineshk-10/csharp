namespace bank
{
    public interface IBankCustomer
    {
        int CustomerId { get; }
        string Name { get; set; }
        string Email { get; set; }
        decimal Balance { get; set; }

        void Deposit(decimal amount);
        bool Withdraw(decimal amount);
        void DisplayInfo();
    }

    public class BankCustomer : IBankCustomer
    {
        public int CustomerId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Balance { get; set; }

        public BankCustomer(int customerId, string name, string email, decimal initialBalance)
        {
            CustomerId = customerId;
            Name = name;
            Email = email;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount > Balance)
                return false;
            Balance -= amount;
            return true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {CustomerId}, Name: {Name}, Email: {Email}, Balance: {Balance:C}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IBankCustomer customer = new BankCustomer(1, "Alice Smith", "alice@example.com", 1000m);
            customer.Deposit(500m);
            customer.Withdraw(200m);
            customer.DisplayInfo();
        }
    }
}