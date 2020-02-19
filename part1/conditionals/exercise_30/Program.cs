using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      string input1 = Console.ReadLine();
      int number1 = Convert.ToInt32(input1);
      if (number1 < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (number1 >0 && number1 <50)
      {
        Console.WriteLine("Fail");
      }
      else if (number1 >49 && number1 <60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (number1 >59 && number1 <70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (number1 >69 && number1 <80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (number1 >79 && number1 <90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (number1 >89 && number1 <101)
      {
        Console.WriteLine("Grade: 5");
      }
      else if (number1 > 100)
      {
        Console.WriteLine("Outstanding!");
      }


    }
  }
}
