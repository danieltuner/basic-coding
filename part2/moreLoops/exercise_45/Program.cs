using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int start = 0;
      int number = Convert.ToInt32(Console.ReadLine());
      int end = number;
      for (int i = start; i <= end; i++)
      {
        Console.WriteLine(i);
      }

    }
  }
}
