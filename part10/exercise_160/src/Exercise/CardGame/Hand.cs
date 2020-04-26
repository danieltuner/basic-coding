namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Hand : IComparable<Hand>
  {
    private List<Card> hand;
    public Hand()
    {
      this.hand = new List<Card>();
    }

    public void Add(Card card)
    {
      if (!this.hand.Contains(card))
      {
        this.hand.Add(card);
      }
    }

    public void Print()
    {
      foreach (Card card in this.hand)
      {
        Console.WriteLine(card.ToString());
      }
    }

    public void Sort()
    {
      this.hand.Sort();
    }


    public int CompareTo(Hand hand)
    {
      int sumOfHand1 = 0;
      foreach (Card card in this.hand)
      {
        sumOfHand1 += card.value;
      }
      int sumOfHand2 = 0;
      foreach (Card card in hand.hand)
      {
        sumOfHand2 += card.value;
      }
      if (sumOfHand1 == sumOfHand2)
      {
        return 0;
      }
      else if ( sumOfHand1 > sumOfHand2)
      {
        return 1;
      }
      else
      {
        return -1;
      }
    }
  }
}