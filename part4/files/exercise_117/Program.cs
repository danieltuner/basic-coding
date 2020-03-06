﻿using System;
using System.IO;

namespace exercise_117
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Ask the user for the file name and print the content of the file
      Console.WriteLine("Which file should have its contents printed?");
      string input = (Console.ReadLine());


      string[] lines = File.ReadAllLines(input);

      foreach (string line in lines)
      {
        Console.WriteLine(line);
      }
      
    }
  }
}
