using System;
using System.Collections.Generic;

namespace exercise_90
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = 0;
      while(true)
      {
        string text = Console.ReadLine();
        if (text == "")
        {
          break;
        }
        string[] pieces = text.Split(",");
        oldest = Convert.ToInt32(pieces[1]);
      }
      Console.WriteLine("Age of the oldest: " + oldest);
    }   
  }
}



