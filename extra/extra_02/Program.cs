using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give three numbers:");
      int num1 = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      int num3 = Convert.ToInt32(Console.ReadLine());
      if (num1 > num2 && (num2 > num3))
      {
        Console.WriteLine("Largest: " + num1);
      }
      if (num2 > num1 && (num1 > num3))
      {
        Console.WriteLine("Largest: " + num2);
      }
      if (num3 > num1 && (num1 > num2))
      {
        Console.WriteLine("Largest: " + num3);
      }

    }
  }
}
