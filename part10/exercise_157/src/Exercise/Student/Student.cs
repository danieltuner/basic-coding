namespace Exercise
{
  using System;
  public class Student : IComparable<Student>
  {

    public string name { get; }

    public Student(string name)
    {
      this.name = name;
    }


    public override string ToString()
    {
      return name;
    }

    //BEGIN SOLUTION
    public int CompareTo(Student another)
    {
      int result = this.name.CompareTo(another.name);
      return result;

      // or: return this.name.CompareTo(another.name);
    }
    //END SOLUTION
  }
}