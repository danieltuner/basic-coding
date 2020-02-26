using System;

namespace exercise_108
{
  class PaymentCard
  {
    private double balance;

    public PaymentCard(double openingBalance)
    {
      // write code here
      this.balance = openingBalance;
     
    }
    public void EatLunch()
    {
        if (this.balance >= 10.6)
        {
            this.balance = this.balance - 10.6;
        }
    }
    public void DrinkCoffee()
    {
        if (this.balance >= 2.0)
        {
            this.balance = this.balance - 2.0;
        }
    }

    public override string ToString()
    {
      // write code here
      return "The card has a balance of " + this.balance + " euros";

    }
  }
}



