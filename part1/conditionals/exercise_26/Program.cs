using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give your age:");
      string input = Console.ReadLine();
      int number = Convert.ToInt32(input);
      if (number <= 1899) 
  {
      Console.WriteLine("You're old");
  }
    }
  }
}
