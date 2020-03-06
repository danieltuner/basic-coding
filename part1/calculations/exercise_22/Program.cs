using System;

namespace exercise_22
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.WriteLine("Give the first number!");
      string input1 = Console.ReadLine();
      int number1 = Convert.ToInt32(input1);
      Console.WriteLine("Give the second number!");
      string input2 = Console.ReadLine();
      int number2 = Convert.ToInt32(input2);
      Console.WriteLine("Give the third number!");
      string input3 = Console.ReadLine();
      int number3 = Convert.ToInt32(input3);
      Console.WriteLine("The average is " + ((number1 + number2 + number3) / 3.0));

    }
  }
}
