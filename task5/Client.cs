using System;

namespace task5;

public class Client
{
    public void ClientCode(Component comp)
    {
        Console.WriteLine("Result: " + comp.Operation());
    }
}