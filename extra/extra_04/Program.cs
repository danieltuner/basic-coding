using System;

namespace extra_04
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give your percent [0 - 100]:");
      int nr = Convert.ToInt32(Console.ReadLine());
      if (nr < 0)
      {
        Console.WriteLine("Impossible");
      }
      else if (nr < 50)
      {
        Console.WriteLine("Fail");
      }
      else if (nr < 60)
      {
        Console.WriteLine("Grade: 1");
      }
      else if (nr < 70)
      {
        Console.WriteLine("Grade: 2");
      }
      else if (nr < 80)
      {
        Console.WriteLine("Grade: 3");
      }
      else if (nr < 90)
      {
        Console.WriteLine("Grade: 4");
      }
      else if (nr <= 100)
      {
        Console.WriteLine("Grade: 5");
      }
      else
      {
        Console.WriteLine("Outstanding!");
      }

    }
  }
}
