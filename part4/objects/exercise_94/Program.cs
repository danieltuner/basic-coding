using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account heikkisAccount = new Account("Heikki's account", 1000.00);
      Account personalAccount = new Account("Personal account", 0.00);
      heikkisAccount.Withdrawal(100.00);
      personalAccount.Deposit(100.00);
      Console.WriteLine("Heikki's account balance: " + heikkisAccount.balance);
      Console.WriteLine("Personal account balance: " + personalAccount.balance);


    }
  }
}



