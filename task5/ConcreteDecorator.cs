using System;

namespace task5;

public class Lightning: Decorator
{
    
    public Lightning(Car car): base(car)
    {
    }

    public override string Operation()
    {
        return $"Lightning({base.Operation()})";
    }
}

public class Tribal: Decorator
{
    
    public Tribal(Car car): base(car)
    {
    }

    public override string Operation()
    {
        return $"Tribal({base.Operation()})";
    }
}

public class Fire: Decorator
{
    
    public Fire(Car car): base(car)
    {
    }

    public override string Operation()
    {
        return $"Fire({base.Operation()})";
    }
}