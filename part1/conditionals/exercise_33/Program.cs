using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give the first string:");
      string UserInput1 = Console.ReadLine();
      Console.WriteLine("Give the second string:");
      string UserInput2 = Console.ReadLine();
      if (UserInput1 == UserInput2)
      {
        Console.WriteLine("Echo!");
      }
      else
      {
        Console.WriteLine("Nope!");
      }

    }
  }
}
