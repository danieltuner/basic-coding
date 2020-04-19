namespace Exercise
{
  public class Furniture : IPackable
  {
    public string typeFurniture;
    public string color;
    public int weight;
    public Furniture(string typeFurniture, string color, int weight)
    {
      this.typeFurniture = typeFurniture;
      this.color = color;
      this.weight = weight;
    }

    public int Weight()
    {
      return this.weight;
    }

    public override string ToString()
    {
      return this.color + " " + this.typeFurniture + " - weight " + this.weight + " kg";
    }
  }
}