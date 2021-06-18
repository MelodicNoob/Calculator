using System;
using CoreLibrary;

namespace ConsoleUI
{
    class Program
    {
        static string[] MathOperations { get; set; } = new string[]{
            "+",
            "-",
            "*",
            "/",
            "%"
        };

        static bool IsInputValidMathOperation(string input)
        {
            foreach (string mathOperation in MathOperations)
            {
                if (mathOperation == input)
                {
                    return true;
                }
            }
            return false;
        }

        static bool IsInputANumber(string input)
        {
            try
            {
                Int32.Parse(input);
            }
            catch
            {
                return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What mathmatical operation would you like to perform? (+, -, *, /, %)");
            string mathOperation = Console.ReadLine();

            // Check whether the user has inputted a correct mathmatics operation
            while (!IsInputValidMathOperation(mathOperation))
            {
                Console.WriteLine("Please enter in a valid math operation!");
                Console.WriteLine("What mathmatical operation would you like to perform? (+, -, *, /, %)");
                mathOperation = Console.ReadLine();
            }

            // Ask the user for numbers to be used in the calculation
            // First number
            Console.WriteLine("What is your first number?");
            string firstNumInput = Console.ReadLine();

            while (!IsInputANumber(firstNumInput))
            {
                Console.WriteLine("Please enter in a number!");
                Console.WriteLine("What is your first number?");
                firstNumInput = Console.ReadLine();
            }

            int firstNum = Int32.Parse(firstNumInput);

            // Second number
            Console.WriteLine("What is your second number?");
            string secondNumInput = Console.ReadLine();
            while (!IsInputANumber(secondNumInput))
            {
                Console.WriteLine("Please enter in a number!");
                Console.WriteLine("What is your second number?");
                secondNumInput = Console.ReadLine();
            }

            int secondNum = Int32.Parse(secondNumInput);

            // Perform mathmatics operation on inputted numbers
            int? result = null;
            switch (mathOperation)
            {
                case "+":
                    result = Calculator.Add(firstNum, secondNum);
                    break;
                case "-":
                    result = Calculator.Minus(firstNum, secondNum);
                    break;
                case "*":
                    result = Calculator.Multiply(firstNum, secondNum);
                    break;
                case "/":
                    result = Calculator.Divide(firstNum, secondNum);
                    break;
                case "%":
                    result = Calculator.Modulus(firstNum, secondNum);
                    break;
                default:
                    break;
            }

            if (result == null)
            {
                Console.WriteLine("Something bad has happened!");
            }
            else
            {
                Console.WriteLine($"The answer for your calculation is { result }.");
            }
        }
    }
}
