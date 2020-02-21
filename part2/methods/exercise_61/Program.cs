using System;

namespace exercise_61
{
  class Program
  {
    public static void Main(String[] args)
    {
    PrintRightTriangle(4);
    Console.WriteLine("");
    ChristmasTree(4);
    Console.WriteLine("");
    ChristmasTree(10);
      

    }

    public static void PrintStars(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write("*");
      }
      Console.WriteLine("");
    }

    public static void PrintSpaces(int number)
    {
      for (int i = 0; i < number; i++)
      {
        Console.Write(" ");
      }
    }

    public static void PrintRightTriangle(int size)
    {
      int space = size - 1;
      for (int i = 1; i <= size; i++)
      {
        PrintSpaces(space);
        PrintStars(i);
        space--;
      }
      
    }

    public static void ChristmasTree(int height)
    {
      
      for (int i = 1; i <= height; i++)
      {
        PrintSpaces(height - i);
        PrintStars((i * 2) -1);
      }
      PrintSpaces(height - 2);
      PrintStars(3);
      PrintSpaces(height - 2);
      PrintStars(3);
    }
  }
}
