using System;
using System.Collections.Generic;

namespace exercise_131
{
  class Program
  {
    public static bool DoesIdentifierAlreadyExist(List<Item> items, string identifier)
    {
      foreach (Item item in items)
      {
        if (item.GetIdentifier() == identifier)
        {
          Console.WriteLine("Identifier already exists. Try again:");
          return true;
        }
      }
        return false;
    }

    public static void Main(string[] args)
    {
      List<Item> items = new List<Item>();

      // Ask for input as shown in the exercise.
      while (true)
      {
        // Asking user for data
        Console.WriteLine("Identifier? (empty will stop)");
        string ident = Console.ReadLine();

        if (ident == "")
        {
          break;
        }

        if (DoesIdentifierAlreadyExist(items, ident) == true)
        {
          continue;
        }

        Console.WriteLine("Name?");
        string name = Console.ReadLine();
      
        
        Item itemObj = new Item(ident, name);
        items.Add(itemObj);
        

        
      }
      // The end printing is ready, don't touch this
      Console.WriteLine("==Items==");
      foreach (Item item in items)
      {
        Console.WriteLine(item);
      }

    }

  }
}
