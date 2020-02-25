using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Enter username:");
      string input1 = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string input2 = Console.ReadLine();
      if (input1 == "alex" && input2 == "sunshine")
      {
        Console.WriteLine("You have successfully logged in!");
      }
      else if (input1 == "emma" && input2 == "haskell")
      {
        Console.WriteLine("You have successfully logged in!");
      }
      else
      {
        Console.WriteLine("Incorrect username or password!");
      }

    }
  }
}

