namespace Exercise
{
  using System;
  using System.Collections.Generic;

  public class LotteryRow
  {
    private List<int> numbers;

    public LotteryRow()
    {
      this.RandomizeNumbers();
    }

    public List<int> Numbers()
    {
      return this.numbers;
    }

    public bool ContainsNumber(int number)
    {
      // Tests whether the number is already among the randomized numbers
      return this.numbers.Contains(number);
    }

    public void RandomizeNumbers()
    {
      // initialize the list for numbers
      this.numbers = new List<int>();
      Random rnd = new Random();
      while (this.numbers.Count < 7)
      {
        int lottery = rnd.Next(1, 41);
        if (!ContainsNumber(lottery))
        {
          this.numbers.Add(lottery);
        }
        
      }
      this.numbers.Sort();
      // Implement the randomization of the numbers by using the method ContainsNumber() here
    }

  }
}