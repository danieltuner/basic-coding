using System;

namespace exercise_124
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
      Counter counter = new Counter();
      counter.Increase();
      Console.WriteLine(counter);
      counter.Increase(3);
      Console.WriteLine(counter);
      counter.Decrease();
      Console.WriteLine(counter);
      counter = null;
      counter.Decrease(2);
      Console.WriteLine(counter);

    }
  }
}
