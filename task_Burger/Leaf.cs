using System;
using System.Collections.Generic;

namespace burger;

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }
    
    public override void Add(Component C) 
    {
        Console.WriteLine("Cannot add to a leaf");
    }

    public override void Remove(Component C)
    {
        Console.WriteLine("Cannot remove from the leaf");
    }

    public override void Display(int depth)
    {
        Console.WriteLine( new String('\t', depth) +  $"[+]{this.getName()}");
    }
} 