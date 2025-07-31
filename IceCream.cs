namespace icecream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Icecream Land!");
            Console.WriteLine("Please choose a flavor:");
            Console.WriteLine("1. Vanilla");
            Console.WriteLine("2. Chocolate");
            Console.WriteLine("3. Strawberry");
            Console.WriteLine("4. Cashew Nut");

            string? choice = Console.ReadLine();
            string flavor = choice switch
            {
                "1" => "Vanilla",
                "2" => "Chocolate",
                "3" => "Strawberry",
                "4" => "Cashew Nut",
                _ => "Unknown"
            };

            if (flavor == "Unknown")
            {
                Console.WriteLine("Invalid selection.");
            }
            else
            {
                Console.WriteLine($"You ordered {flavor} ice cream. Great taste,Enjoy!");
            }
        }
    }
}
