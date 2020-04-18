namespace Exercise
{
  public class Student : Person
  {
    public int credits {get; set;}
    public Student(string name, string adress) : base(name, adress)
    {
      this.credits = credits;
    }

    public void Study()
    {
      this.credits++;
    }

    public override string ToString()
    {
      return base.ToString() + " credits: " + this.credits;
    }
  }
}