using System;
using System.Collections.Generic;


namespace burger;

class Composite: Component
{
    List<Component> children = new List<Component>();

    public Composite(string name): base(name)
    {
    }

    public override void Add(Component C)
    {
        if (C is not null)
        {
            children.Add(C);
        }
        else 
        {
            throw new NotImplementedException();
        }
    }

    public override void Remove(Component C)
    {
        if (children.Contains(C) && C is not null)
        {
            children.Remove(C);
        }
        else
        {
            throw new NotImplementedException();
        }
    }

    public override void Display(int depth = 0)
    {
        
        Console.WriteLine( new String('\t', depth) +  $"[+]{this.getName()}: ");
        foreach(Component comp in children)
        {
            comp.Display(depth+1);
        }
    }
}