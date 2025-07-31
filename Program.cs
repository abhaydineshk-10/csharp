namespace Parkingfee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Parking Fee Calculator ===");

            double hours = ReadPositiveDouble("Enter parking duration in hours: ");
            double ratePerHour = 2.50;
            double minimumFee = 5.00;

            double fee = Math.Max(Math.Ceiling(hours) * ratePerHour, minimumFee);

            Console.WriteLine($"Total parking fee: ${fee:F2}");
        }

        static double ReadPositiveDouble(string prompt)
        {
            double value;
            do
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (double.TryParse(input, out value) && value > 0)
                    return value;
                Console.WriteLine("Please enter a valid positive number.");
            } while (true);
        }
    }
}
