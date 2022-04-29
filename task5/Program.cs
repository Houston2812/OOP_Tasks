using System;

namespace task5;

class Task5Main{
    static public void Main(string[] args)
    {
        Client client = new Client();

        ConcreteCar mitsubishi = new ConcreteCar("Mitsubishi");

        Console.WriteLine("First Machnie: ");
        client.ClientCode(mitsubishi);    
        Console.WriteLine();

        Lightning lightning = new Lightning(mitsubishi);
        Tribal tribal = new Tribal(lightning);

        Console.WriteLine("Decorated car:");
        client.ClientCode(tribal);    

    }
}