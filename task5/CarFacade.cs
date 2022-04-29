using System;

namespace task5;

public class CarFacade
{
    private Component car;

    public bool CreateCar(string model)
    {
        if (model == "Mitsubishi Eclipse")
            this.car = new MitsubishiEclipse();
        else if (model == "Asura RSX")
            this.car = new AsuraRSX();
        else if (model == "Toyota Celica")
            this.car = new ToyotaCelica();
        else   
            return false;
        return true;
    }

    public bool AddVinyl(string vinyl)
    {
        if (vinyl == "Tribal") 
            this.car = new Tribal(this.car);
        else if (vinyl == "Lightning")
            this.car = new Lightning(this.car);
        else if (vinyl == "Fire")
            this.car = new Fire(this.car);
        else 
            return false;
        return true;
    }

    public void GetStyle()
    {
        Console.WriteLine("Final style: " + this.car.Operation());
    }

}