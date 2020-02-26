using System;

namespace exercise_106
{
  class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
      this.balance = openingBalance;
    }

    public override string ToString()
    {
      // write code here
      return "The card has a balance of " + this.balance + " euros";

    }
  }
}



