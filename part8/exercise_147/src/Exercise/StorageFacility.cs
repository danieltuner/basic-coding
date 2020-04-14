using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    private Dictionary<string, List<string>> storageUnits;
    
    public StorageFacility()
    {
      this.storageUnits = new Dictionary<string, List<string>>();
    }

    public void Add(string unit, string item)
    {
      if (!this.storageUnits.ContainsKey(unit))
      {
        this.storageUnits.Add(unit, new List<string>());
      }
      this.storageUnits[unit].Add(item);
    }

    public List<string> Contents(string storageUnit)
    {
      if (!this.storageUnits.ContainsKey(storageUnit))
      {
        this.storageUnits.Add(storageUnit, new List<string>());
      }
      return this.storageUnits[storageUnit];
    }

    public void Remove(string storageUnit, string item)
    {
      this.storageUnits[storageUnit].Remove(item);
      if (this.storageUnits[storageUnit].Count == 0)
      {
        this.storageUnits.Remove(storageUnit);
      }
    }

    public List<string> StorageUnits()
    {
      List<string> listStorageUnits = new List<string>();
      Dictionary<string, List <string>>.KeyCollection key = this.storageUnits.Keys;
      foreach (string storageUnits in key)
      {
        listStorageUnits.Add(storageUnits);
      }
      return listStorageUnits;
    }
  }
}