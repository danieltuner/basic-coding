using System;
using System.Collections.Generic;

namespace exercise_92
{
  class Program
  {
    public static void Main(string[] args)
    {
      int oldest = Convert.ToInt32(DateTime.Now.Year);
      string name = "";
      while(true)
      {
        string text = Console.ReadLine();
        if (text == "")
        {
          break;
        }
        string[] pieces = text.Split(",");
        if (oldest > Convert.ToInt32(pieces[1]))
        {
          oldest = Convert.ToInt32(pieces[1]);
        }
        if (name.Length < pieces[0].Length)
        {
          name = pieces[0];
        }
        
      }
      Console.WriteLine("Longest name: " + name);
      Console.WriteLine("Highest age: " + (Convert.ToInt32(DateTime.Now.Year) - oldest));
    }
  }
}



