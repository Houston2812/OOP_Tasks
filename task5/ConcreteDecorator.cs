using System;

namespace task5;

public class Lightning: Decorator
{
    
    public Lightning(Component comp): base(comp)
    {
    }

    public override string Operation()
    {
        return $"Lightning({base.Operation()})";
    }
}

public class Tribal: Decorator
{
    
    public Tribal(Component comp): base(comp)
    {
    }

    public override string Operation()
    {
        return $"Tribal({base.Operation()})";
    }
}

public class Fire: Decorator
{
    
    public Fire(Component comp): base(comp)
    {
    }

    public override string Operation()
    {
        return $"Fire({base.Operation()})";
    }
}