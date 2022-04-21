using System;

namespace task4;

public class ConcreteColleague1: Colleague{


    public ConcreteColleague1(Mediator mediator, List<Colleague> blacklist = null):base(mediator, blacklist)
    {
    }
    
    // unicast
    public void Send(string message, Colleague recipient)
    {
        if (blacklist.Contains(recipient) == false) {
            mediator.Send(message, recipient);
        } 
    }     
        
    // multicast
    public void Send(string message, List<Colleague> recipients )
    {
        foreach(Colleague col in recipients)
        {
            if (blacklist.Contains(col) == false) {
                mediator.Send(message, col);
            }
        }
    }

    // broadcast
    public void Send(string message)
    {
        mediator.Send(message, this, true);
    }

    public override void Notify(string message, Colleague colleague)
    {
        if (this.blacklist.Contains(colleague) == false) {
            Console.WriteLine("Colleague1 gets message: " + message);
        }
    }

    public override void AddToBlacklist(Colleague colleague)
    {
        if (colleague is not null)
            this.blacklist.Add(colleague);
        else
            throw new NotImplementedException(); 
    }

     public override void GetBlacklist()
    {
        Console.WriteLine("Blacklist of Colleague1");
        foreach(Colleague col in this.blacklist)
        {   
            Console.Write(col.ToString() + ", ");
        }
        Console.WriteLine();
    }
    public override string ToString()
    {
        return "This is Colleague1";
    }
}


public class ConcreteColleague2: Colleague{
    public ConcreteColleague2(Mediator mediator, List<Colleague> blacklist = null):base(mediator, blacklist)
    {
    }

    // unicast
    public void Send(string message, Colleague recipient)
    {
        if (blacklist.Contains(recipient) == false) {
            mediator.Send(message, recipient);
        } 
    }

    // multicast
    public void Send(string message, List<Colleague> recipients)
    {
        foreach(Colleague col in recipients)
        {
            if (blacklist.Contains(col) == false) {
                mediator.Send(message, col);
            }
        }
    }

    //broadcast
    public void Send(string message)
    {
        mediator.Send(message, this, true);
    }

    public override void Notify(string message, Colleague colleague)
    {
        if (this.blacklist.Contains(colleague) == false) {
            Console.WriteLine("Colleague2 gets message: " + message);
        } 
    }

    public override void AddToBlacklist(Colleague colleague)
    {   
        if (colleague is not null)
            this.blacklist.Add(colleague);
        else
            throw new NotImplementedException(); 
    }

    public override void GetBlacklist()
    {
        Console.WriteLine("Blacklist of Colleague2");
        foreach(Colleague col in this.blacklist)
        {   
            Console.Write(col.ToString() + ", ");
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return "This is Colleague2";
    }
}

public class ConcreteColleague3: Colleague{
    public ConcreteColleague3(Mediator mediator, List<Colleague> blacklist = null):base(mediator, blacklist )
    {
    }


    // unicast 
    public void Send(string message, Colleague recipient)
    {
        if (blacklist.Contains(recipient) == false) {
            mediator.Send(message, recipient);
        }
        
    }

    // multicast
    public void Send(string message, List<Colleague> recipients)
    {
        foreach(Colleague col in recipients)
        {
            if (blacklist.Contains(col) == false) {
                mediator.Send(message, col);
            }
        }
    }


    // broadcast
    public void Send(string message)
    {
        mediator.Send(message, this, true);
    }

    public override void Notify(string message, Colleague colleague)
    {
        if (this.blacklist.Contains(colleague) == false) {
            Console.WriteLine("Colleague3 gets message: " + message);
        }
    }

    public override void AddToBlacklist(Colleague colleague)
    {
        if (colleague is not null)
            this.blacklist.Add(colleague);
        else
            throw new NotImplementedException(); 
    }

    public override void GetBlacklist()
    {
        Console.WriteLine("Blacklist of Colleague3");
        foreach(Colleague col in this.blacklist)
        {   
            Console.Write(col.ToString() + ", ");
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return "This is Colleague3";
    }
}

public class ConcreteColleague4: Colleague{
    public ConcreteColleague4(Mediator mediator, List<Colleague> blacklist = null):base(mediator, blacklist)
    {
    }


    // unicast
    public void Send(string message, Colleague recipient)
    {
        if (blacklist.Contains(recipient) == false) {
            mediator.Send(message, recipient);
        }
        
    }

    // multicast
    public void Send(string message, List<Colleague> recipients)
    {
        foreach(Colleague col in recipients)
        {
            if (blacklist.Contains(col) == false) {
                mediator.Send(message, col);
            }
        }
    }

    // broadcast
    public void Send(string message)
    {
        mediator.Send(message, this, true);
    }

    public override void Notify(string message, Colleague colleague)
    {
        if (this.blacklist.Contains(colleague) == false) {
            Console.WriteLine("Colleague4 gets message: " + message);
        }
    }

    public override void AddToBlacklist(Colleague colleague)
    {
        if (colleague is not null)
            this.blacklist.Add(colleague);
        else
            throw new NotImplementedException(); 
    }

    public override void GetBlacklist()
    {
        Console.WriteLine("Blacklist of Colleague4");
        foreach(Colleague col in this.blacklist)
        {   
            Console.Write(col.ToString() + ", ");
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return "This is Colleague4";
    }
}