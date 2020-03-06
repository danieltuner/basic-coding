using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int first = 1;
      int second = 2;
      first = Convert.ToInt32(Console.ReadLine());
      second = Convert.ToInt32(Console.ReadLine());
      if (first > second)
      {
        Console.WriteLine(first + " is greater than " + second + ".");
      }
      else if (first < second)
      {
        Console.WriteLine(first + " is less than " + second + ".");
      }
      else if (first == second)
      {
        Console.WriteLine(first + " is equal to " + second + ".");
      }


    }
  }
}
