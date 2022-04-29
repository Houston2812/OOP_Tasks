using System;

namespace task5;

public class ConcreteCar : Car
{
    private string model; 

    public ConcreteCar(string model):base()
    {
        this.model = model;
    }
    public override string Operation()
    {
        return this.model;
    }
}