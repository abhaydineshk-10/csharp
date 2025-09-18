using System;

namespace payment_processing_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string method = "CreditCard";
            string accountNumber = "1234-5678-9012-3456";
            decimal amount = 100.00m;

            if (amount <= 0 || string.IsNullOrWhiteSpace(accountNumber))
            {
                Console.WriteLine("Invalid payment details.");
                return;
            }

            Console.WriteLine($"Processing {method} payment for {amount:C}...");
            // Simulate payment processing
            Console.WriteLine("Payment processed successfully.");
        }
    }
}