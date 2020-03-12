using System;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give integers, 'end' quits:");
      
      int sum = 0;
      string end = Console.ReadLine();
      
      
      while (true)
      {
        int input = Convert.ToInt32(Console.ReadLine());
        sum += input;

        if (end == "end")
        {
          break;
        }
      }
      Console.WriteLine("Sum: " + sum);
    }
  }
}
