using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number:");
      string input1 = Console.ReadLine();
      int number1 = Convert.ToInt32(input1);
      if ((number1 % 2) == 0)
      {
        Console.WriteLine("It is even.");
      }
      else
      {
        Console.WriteLine("It is odd.");
      }

    }
  }
}
