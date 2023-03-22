using System;
namespace Calculator
{
	public class Calculate
	{
        public static double Run(string input)
        {
            string[] inputs = input.Split(" ");

            if (!inputs.Length.Equals(3))
            {
                throw new ArgumentNullException(null, "Incorrect equation format");
            }

            double num1 = Convert.ToDouble(inputs[0]);
            double num2 = Convert.ToDouble(inputs[2]);
            string op = inputs[1];

            return op switch
            {
                "+" => Add(num1, num2),
                "-" => Subtract(num1, num2),
                "*" => Multiply(num1, num2),
                "/" => Divide(num1, num2),
                _ => throw new ArgumentException("Please enter a valid operator")
            };
        }

        private static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        private static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }

        private static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        private static double Divide(double num1, double num2)
        {
            if (num2.Equals(0))
            {
                throw new DivideByZeroException("Cannot divide by 0");
            }

            return num1 / num2;
        }
    }
}

