// See https://aka.ms/new-console-template for more information
using System;

namespace burger;

class BurgerMain{
    static void Main(string[] args){

        MenuController Mac = new MenuController("Mac Menu");
        Console.WriteLine("Please enter your order:");
        Console.WriteLine("Options:");
        Console.WriteLine("\t[+] Small Menu");
        Console.WriteLine("\t[+] Big Menu");
        Console.Write("Choice is: ");
        string choice = Console.ReadLine();
        
        Mac.GetMenu(choice.Trim());

    }
}
