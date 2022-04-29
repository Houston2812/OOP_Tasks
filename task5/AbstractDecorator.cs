using System;

namespace task5;

public abstract class Decorator: Car
{
    protected Car _car;

    public Decorator(Car car)
    {
        this._car = car;
    }

    public void SetComponent(Car car)
    {
        this._car = car;
    }

    public override string Operation()
    {
        if (this._car != null)
        {
            return this._car.Operation();
        }
        else
        {
            return string.Empty;
        }
    }

}