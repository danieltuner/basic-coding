using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {
      while(true)
      {
        string text = Console.ReadLine();
        if (text == "")
        {
          break;
        }
        string[] pieces = text.Split(" ");
        for (int i = 0; i < pieces.Length; i++)
        {
          if (pieces[i].Contains("av"))
          { 
            Console.WriteLine(pieces[i]);
          }
        }
      }
    }

  }

}

