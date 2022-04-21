using System;
using System.Collections.Generic;
namespace task4;

public class ConcreteMediator: Mediator{
    private List<Colleague> colleagues = new List<Colleague>();

    
    public override void Send(string message, Colleague colleague, bool brodcast = false)
    {   
        if (brodcast)
        {
            foreach(Colleague col in this.colleagues)
            {
                if (col != colleague)
                {
                    col.Notify(message, colleague);
                }
            }
        }
        else 
        {
            foreach(Colleague col in this.colleagues)
            {
                if (col == colleague) {
                    col.Notify(message, colleague);
                    break;
                }
            }
        }

    }

    public override void addColleague(Colleague colleague)
    {
        if (colleague is not null)
            this.colleagues.Add(colleague);
        else
            throw new NotImplementedException();
    }
}