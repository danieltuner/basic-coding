using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("How many days?");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      Console.WriteLine (number * 60 * 60 * 24);
       

    }
  }
}
