using System;
using System.IO;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter a positive low number: ");
        double lowNumb;
        while (!double.TryParse(Console.ReadLine(), out lowNumb) || lowNumb <= 0)
        {
            Console.WriteLine("Please enter a positive number.");
            Console.Write("Enter a positive low number: ");
        }

        Console.Write("Enter a high number greater than the low number: ");
        double highNumb;
        while (!double.TryParse(Console.ReadLine(), out highNumb) || highNumb <= lowNumb)
        {
            Console.WriteLine("Please enter a high number greater than the low number.");
            Console.Write("Enter a high number greater than the low number: ");
        }

        
        int arraySize = (int)(highNumb - lowNumb) + 1;
        double[] numbersArray = new double[arraySize];

       
        for (int i = 0; i < arraySize; i++)
        {
            numbersArray[i] = highNumb - i;
        }

        
        string filePath = "numbers.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = arraySize - 1; i >= 0; i--)
            {
                writer.WriteLine(numbersArray[i]);
            }
        }

        Console.WriteLine($"Numbers have been written to {filePath} in reverse order.");
    }
}
