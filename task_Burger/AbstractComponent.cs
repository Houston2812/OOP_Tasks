using System;

namespace burger;

public abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public string getName()
    {
        return this.name;
    }
    public abstract void Add(Component C);
    public abstract void Remove(Component C);
    public abstract void Display(int depth);


}