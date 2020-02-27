using System;
using System.Collections.Generic;

namespace exercise_113
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      // Remember also to create the file Book.cs and class in it!
      List<Book> list = new List<Book>();

      while (true)
      {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        if (name == "")
        {
          break;
        }
        Console.Write("Pages: ");
        string pages = Console.ReadLine();
        Console.Write("Publication year: ");
        string publicationYear = Console.ReadLine();

        list.Add(new Book(name, pages, publicationYear));
      }
      Console.WriteLine();
      Console.Write("What information will be printed? ");
      string answer = Console.ReadLine();

      foreach (Book item in list)
      if (answer == "everything")
      {
        Console.WriteLine(item.name + ", " + item.pages + " pages, " + item.publicationYear);
      }
      else if (answer == "title")
      {
        Console.WriteLine(item.name);
      }
    }
  }
}




