using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace task3
{   
    class Task3Main
    {
        static void Main(string[] args)
        {
            TwitterProfle Ali = new TwitterProfle("Ali");
            TwitterProfle Aziz = new TwitterProfle("Aziz");
            TwitterProfle Huseyn = new TwitterProfle("Huseyn");
            TwitterProfle Abdulla = new TwitterProfle("Abdulla");
            TwitterProfle Amin = new TwitterProfle("Amin");

            Aziz.follow(Ali);
            Huseyn.follow(Ali);
            Ali.follow(Abdulla);
            Ali.follow(Huseyn);

            List<Observer> followers = Ali.Followers();
            List<Observer> subscriptions = Huseyn.Subscriptions();

            Console.WriteLine($"[*] Followers of {Ali.getName()}: ");
            followers.ForEach(follower => Console.WriteLine("\t * " + follower.GetName()));
            
            Console.WriteLine($"[*] Subscriptions of {Huseyn.getName()}: ");
            subscriptions.ForEach(s => Console.WriteLine("\t * " + s.GetName()));
            
        }
    }

}

