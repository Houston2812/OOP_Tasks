using System;

namespace task5;

public class MitsubishiEclipse: Component
{
    private string model; 

    public MitsubishiEclipse():base()
    {
        this.model = "MitsubishiEclipse";
    }
    public override string Operation()
    {
        return this.model;
    }
}

public class ToyotaCelica: Component
{
    private string model; 

    public ToyotaCelica():base()
    {
        this.model = "ToyotaCelica";
    }
    public override string Operation()
    {
        return this.model;
    }
}

public class AsuraRSX: Component
{
    private string model; 

    public AsuraRSX():base()
    {
        this.model = "AsuraRSX";
    }
    public override string Operation()
    {
        return this.model;
    }
}