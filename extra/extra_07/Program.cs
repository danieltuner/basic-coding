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
      
      
      
      while (true)
      {
        string input =Console.ReadLine();
        

        if (input == "end")
        {
          break;
        }
        sum += Convert.ToInt32(input);
      }
      Console.WriteLine("Sum: " + sum);
    }
  }
}
