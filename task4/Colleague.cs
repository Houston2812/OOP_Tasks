using System;

namespace task4;

public abstract class Colleague{
    protected Mediator mediator;
    protected List<Colleague> blacklist;
    public Colleague(Mediator mediator, List<Colleague> blacklist)
    {
        this.mediator = mediator;
        blacklist = blacklist ?? new List<Colleague>();
        this.blacklist = blacklist;
    }

    public abstract void AddToBlacklist(Colleague colleague);
    
    public abstract void GetBlacklist();
    public abstract void Notify(string message, Colleague colleague);
}