// See https://aka.ms/new-console-template for more information
using System;

namespace task4;

class Task4Main{
   static void Main(string[] args){
        ConcreteMediator m = new ConcreteMediator();

        ConcreteColleague1 c1 = new ConcreteColleague1(m);
        ConcreteColleague2 c2 = new ConcreteColleague2(m);
        ConcreteColleague3 c3 = new ConcreteColleague3(m);
        ConcreteColleague4 c4 = new ConcreteColleague4(m);
        
        m.addColleague(c1);
        m.addColleague(c2);
        m.addColleague(c3);
        m.addColleague(c4);

        
        Console.WriteLine("Unicast example");
        c3.Send("Hi, it is C3", c4);

        Console.WriteLine();
        Console.WriteLine("Multicast example");
        c1.Send("Hi, it is C1", new List<Colleague> {c2,c3});
        
        Console.WriteLine();
        Console.WriteLine("Blacklist example");

        c1.AddToBlacklist(c2);
        Console.WriteLine("Blacklisted Colleague2");
        c1.Send("Hi, it is C1", new List<Colleague> {c2,c3});

        Console.WriteLine();
        Console.WriteLine("Broadcast example");
        c2.Send("Hi, it is C2");

    }
}
