using System.Collections.Generic;

namespace Exercise
{
  public class Abbreviations
  {
    private Dictionary<string, string> förkortning;

    public Abbreviations()
    {
      this.förkortning = new Dictionary<string, string>();
    }
    public void AddAbbreviation(string abbreviation, string explanation)
    {
      this.förkortning.Add(abbreviation, explanation);
    }

    public bool HasAbbreviation(string abbreviation)
    {
      if (this.förkortning.ContainsKey(abbreviation))
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string FindExplanationFor(string abbreviation)
    {
      if (HasAbbreviation(abbreviation))
      {
        return förkortning[abbreviation];
      }
      else
      {
        return "not found";
      }
    }
  }
}