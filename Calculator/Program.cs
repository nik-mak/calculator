namespace Calculator;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the most amazing calulator console app!");
        Console.WriteLine("Enter your first equation to get started!");

        while (true)
        {
            string? input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException($"Invalid input: {input}");
            }

            if (input == "q" || input == "exit")
            {
                break;
            }

            try
            {
                Console.WriteLine($"> {Calculate.Run(input)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

