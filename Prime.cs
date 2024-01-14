using System;

class Program
{
    static void Main()
    {
        double lowNumber = GetUserInput("Enter a positive low number: ", ValidatePositiveNumber);
        double highNumber = GetUserInput("Enter a high number greater than the low number: ", ValidateHighNumber, lowNumber);

        PrintPrimeNumbers(lowNumber, highNumber);
    }

    static void PrintPrimeNumbers(double lowNumber, double highNumber)
    {
        Console.WriteLine($"Prime numbers between {lowNumber} and {highNumber}:");
        for (double i = lowNumber; i <= highNumber; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }

    static bool IsPrime(double number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (double i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static double GetUserInput(string prompt, Func<double, double, bool> validationFunction, double comparisonValue = 0)
    {
        double userInput;

        do
        {
            Console.Write(prompt);
        } while (!double.TryParse(Console.ReadLine(), out userInput) || !validationFunction(userInput, comparisonValue));

        return userInput;
    }

    static bool ValidatePositiveNumber(double value, double comparisonValue)
    {
        return value > 0;
    }

    static bool ValidateHighNumber(double value, double comparisonValue)
    {
        return value > comparisonValue;
    }
}
