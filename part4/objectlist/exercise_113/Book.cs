using System;
using System.Collections.Generic;

namespace exercise_113
{
  public class Book
  {
      public string name { get; set; }

      public string pages { get; set; }

      public string publicationYear { get; set; }

      public Book(string name, string pages, string publicationYear)
      {
          this.name = name;
          this.pages = pages;
          this.publicationYear = publicationYear;
      }

      public override string ToString()
      {
          return this.name + ", " + this.pages + ", " + this.publicationYear;
      }
  }
}




