using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      int countNeg = 0;
    while (true)
    {
      Console.WriteLine("Give a number:");
      int number = Convert.ToInt32(Console.ReadLine());
      if (number == 0)
      {
        break;
      }
      if (number < 0)
      {
        countNeg ++;
      }
    }
    Console.WriteLine("Total amount of negative numbers: " + countNeg);
    }
  }
}
