using System;

namespace extra_08
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      ChristmasTree(4);

    }
    public static void PrintStars(int nr)
    {
      for (int i = 0; i < nr; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }
    public static void PrintSpaces(int nr)
    {
      for (int i = 0; i < nr; i++)
      {
        Console.WriteLine(" ");
      }
    }
    public static void ChristmasTree(int height)
    {
      for (int i = 1; i <= height; i++)
      {
        PrintSpaces(height -i);
        PrintStars((i* 2) -1);
      }
      PrintSpaces(height -2);
      PrintStars(3);
      PrintSpaces(height -2);
      PrintStars(3);
    }
  }
}
