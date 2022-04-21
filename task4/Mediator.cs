using System;
namespace task4;

public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague, bool brodcast = false);
    public abstract void addColleague(Colleague colleague);
}

