using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Where to?");
      int number1 = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Where from?");
      int number2 = Convert.ToInt32(Console.ReadLine());
      int start = number2;
      int end = number1;
      for (int i = start; i <= end; i++)
      {
        Console.WriteLine(i);
      }


      
    }
  }
}
