using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
    public static void Main(string[] args)
    {
      while(true)
      {
      string text = Console.ReadLine();
      string[] pieces = text.Split(" ");
      if (text == "")
      {
        break;
      }
      for (int i = 0; i < pieces.Length; i++)
      {
        Console.WriteLine(pieces[i]);
      }
      }
    }
  }
}

