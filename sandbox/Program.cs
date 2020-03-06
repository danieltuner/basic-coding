    using System;

    namespace sandbox
    {
        public class Item
    {
    private string name;

    public Item(string name) 
    {
        this.name = name;
    }
    
    // In C# this could also be done with { get; set; for the varible}
    // That way the variable would be public
    // For this example, we want to protect it and keep it private
    public string GetName()
    {
        return this.name;
    }

    public string SetName(string name) 
    {
        this.name = name;
    }

    public override string ToString()
    {
        return this.name;
    }
    }
    }
