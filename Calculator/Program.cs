namespace Calculator;

class Program
{
    static void Main(string[] args)
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
                Console.WriteLine($"> {Calculate(input)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    static double Calculate(string input)
    {
        string[] inputs = input.Split(" ");

        if (!inputs.Length.Equals(3))
        {
            throw new ArgumentNullException("Incorrect equation format");
        }

        double num1 = Convert.ToDouble(inputs[0]);
        double num2 = Convert.ToDouble(inputs[2]);
        string op = inputs[1];

        return op switch
        {
            "+" => num1 + num2,
            "-" => num1 - num2,
            "*" => num1 * num2,
            "/" => Divide(num1, num2),
            _ => throw new ArgumentException("Please enter a valid equation")
        };
    }

    static double Divide(double num1, double num2)
    {
        if (num2.Equals(0))
        {
            throw new DivideByZeroException("Cannot divide by 0");
        }

        return num1 / num2;
    }
}

