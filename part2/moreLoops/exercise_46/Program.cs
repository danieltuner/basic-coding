using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int number = Convert.ToInt32(Console.ReadLine());
      int start = number;
      int end = 100;
      for (int i = start; i <= end; i++)
      {
        Console.WriteLine(i);
      }

    }
  }
}
