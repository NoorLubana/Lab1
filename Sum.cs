using System;


class Program
{
    static void Main()
    {
        double lowNumber = GetUserInput("Enter a positive low number: ", ValidatePositiveNumber);
        double highNumber = GetUserInput("Enter a high number greater than the low number: ", ValidateHighNumber, lowNumber);

        List<double> numbersList = GenerateNumbersList(lowNumber, highNumber);

        string filePath = "numbers.txt";
        WriteNumbersToFile(filePath, numbersList);

        List<double> readNumbersList = ReadNumbersFromFile(filePath);

        double sum = CalculateSum(readNumbersList);

        Console.WriteLine($"Sum of the numbers read from the file: {sum}");
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

    static List<double> GenerateNumbersList(double lowNumber, double highNumber)
    {
        List<double> numbersList = new List<double>();

        for (double i = highNumber; i >= lowNumber; i--)
        {
            numbersList.Add(i);
        }

        return numbersList;
    }

    static void WriteNumbersToFile(string filePath, List<double> numbersList)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (var number in numbersList)
            {
                writer.WriteLine(number);
            }
        }
    }

    static List<double> ReadNumbersFromFile(string filePath)
    {
        List<double> readNumbersList = new List<double>();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (double.TryParse(line, out double number))
                {
                    readNumbersList.Add(number);
                }
            }
        }

        return readNumbersList;
    }

    static double CalculateSum(List<double> numbersList)
    {
        double sum = 0;
        foreach (var number in numbersList)
        {
            sum += number;
        }
        return sum;
    }
}
