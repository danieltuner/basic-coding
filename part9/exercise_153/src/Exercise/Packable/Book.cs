namespace Exercise
{
  public class Book : IPackable
  {
    public string author;
    public string title;
    public int publicationYear;
    public int weight;

    public Book(string author, string title, int publicationYear)
    {
      this.author = author;
      this.title = title;
      this.publicationYear = publicationYear;
      this.weight = 1;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.author + ": " + this.title + " (" + this.publicationYear + ")";
    }
  }
}