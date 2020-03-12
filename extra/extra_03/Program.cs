using System;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("How many numbers?");
      int input = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give " + input + " numbers:");
      int times = 0;
      int count = 0;
      int sum = 0;
      while (true)
      {
        count = Convert.ToInt32(Console.ReadLine());
        times++;
        if (times == input)
        {
          break;
        }
        else
        {
          sum = count + sum;
        }
      
      }
      double avarage = sum / times;
      
      Console.WriteLine("Therir sum: " + sum);
      Console.WriteLine("Their total: " + count);
      Console.WriteLine("Their avarage: " + avarage);

    }
  }
}
