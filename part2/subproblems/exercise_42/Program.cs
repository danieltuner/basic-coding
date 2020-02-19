using System;

namespace exercise_42
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
      int sum = first + second;
      double squareRoot = Math.Sqrt(sum);
      Console.WriteLine(squareRoot);
    
    }
  }
}
