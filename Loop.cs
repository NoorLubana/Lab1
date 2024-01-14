using System;

class Program
{
    static void Main()
    {
        double lowNumber = GetPositiveLowNumber();
        double highNumber = GetHighNumber(lowNumber);

        Console.WriteLine($"You entered a positive low number: {lowNumber}");
        Console.WriteLine($"You entered a high number: {highNumber}");
    }

    static double GetPositiveLowNumber()
    {
        double lowNumber;

        while (true)
        {
            Console.Write("Enter a positive low number: ");
            if (double.TryParse(Console.ReadLine(), out lowNumber) && lowNumber > 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a positive number.");
            }
        }

        return lowNumber;
    }

    static double GetHighNumber(double lowNumber)
    {
        double highNumber;

        while (true)
        {
            Console.Write("Enter a high number greater than the low number: ");
            if (double.TryParse(Console.ReadLine(), out highNumber) && highNumber > lowNumber)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a high number greater than the low number.");
            }
        }

        return highNumber;
    }
}

