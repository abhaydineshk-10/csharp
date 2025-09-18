namespace PosNegZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            if (double.TryParse(Console.ReadLine(), out double number))
            {
                Console.WriteLine(PosNegZero(number));
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        static string PosNegZero(double num)
        {
            if (num > 0)
                return "Positive";
            else if (num < 0)
                return "Negative";
            else
                return "Zero";
        }
    }
}