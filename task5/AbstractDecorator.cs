using System;

namespace task5;

public abstract class Decorator: Component
{
    protected Component _comp;

    public Decorator(Component comp)
    {
        this._comp = comp;
    }

    public void SetComponent(Component comp)
    {
        this._comp = comp;
    }

    public override string Operation()
    {
        if (this._comp != null)
        {
            return this._comp.Operation();
        }
        else
        {
            return string.Empty;
        }
    }

}