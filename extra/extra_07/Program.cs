using System;

namespace extra_07
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:
      Console.WriteLine("Give integers, 'end' quits:");
      string end = "";
      int sum = 0;
      
      
      while (true)
        
        if (end == "end")
        {
          break;
        }
        else
        {
          int input = Convert.ToInt32(Console.ReadLine());
          sum = input + sum;

        }
      Console.WriteLine("Sum: " + sum);
    }
  }
}
