using System;

namespace NumberDifferenceCalculator
{
   class Program
   {
       static void Main(string[] args)
      {

          Console.Write("Enter the low number: ");
          int LowNumb = Convert.ToInt32(Console.ReadLine());


         Console.Write("Enter the high number: ");
         int HighNumb = Convert.ToInt32(Console.ReadLine());


           int difference = HighNumb - LowNumb;


       Console.WriteLine($"The difference between {HighNumb} and {LowNumb} is: {difference}");


         Console.ReadLine();
      }
  }
}






