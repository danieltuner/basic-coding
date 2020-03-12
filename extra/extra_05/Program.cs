using System;
using System.Collections.Generic;

namespace extra_05
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      for (int i = 1; i < 6; i++)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("Give words, 'end' quits:");

      List<string> word = new List<string>();
      string words = "";
      
      while (true)
      {
        words = Console.ReadLine();
        if (words == "end")
        {
          break;
        }
        else{
          word.Add(words);
        }
        

      }
      word.ForEach(Console.WriteLine);

    }
  }
}
