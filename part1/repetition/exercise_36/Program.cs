using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
  while (true)
  {
    Console.WriteLine("Give a number:");
    string Input = Console.ReadLine();
    int intValue = Convert.ToInt32(Input);
    if (intValue == 0)
    {
      break;
    }
    if (intValue < 0)
    {
      Console.WriteLine("That is negative");
    }
    if (intValue > 0)
    {
      Console.WriteLine(intValue * intValue);
    }
  }
    }
  }
}
