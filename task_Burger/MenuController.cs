using System;

namespace burger;

public class MenuController
{
    private string name;
    private Composite MacMenu;
    public MenuController(string name)
    {
        this.name = name;
        this.MacMenu = new Composite(name);
   
    }

    private Composite BigMenu()
    {
        Composite BigMenu = new Composite("Big Menu");
        
        Leaf IceCream = new Leaf("Ice cream");
        Leaf Cola = new Leaf("Cola");
        Composite BigBurger = new Composite("Big Burger");

        Leaf Meat = new Leaf("Meat");
        Leaf Buns = new Leaf("Buns");
        Leaf Cheese = new Leaf("Cheese");

        BigBurger.Add(Meat);
        BigBurger.Add(Meat);
        BigBurger.Add(Buns);
        BigBurger.Add(Cheese);

        BigMenu.Add(BigBurger);
        BigMenu.Add(IceCream);
        BigMenu.Add(Cola);

        return BigMenu;
    }

    private Composite SmallMenu()
    {
        Composite SmallMenu = new Composite("Small Menu");
        
        Leaf Fries = new Leaf("Fries");
        Leaf Cola = new Leaf("Cola");
        
        Composite SmallBurger = new Composite("Small Burger");
        Leaf Meat = new Leaf("Meat");
        Leaf Bunns = new Leaf("Bunns");
        Leaf Cheese = new Leaf("Cheese");

        SmallBurger.Add(Meat);
        SmallBurger.Add(Bunns);
        SmallBurger.Add(Cheese);

        SmallMenu.Add(SmallBurger);
        SmallMenu.Add(Fries);
        SmallMenu.Add(Cola);
        
        return SmallMenu;

    }
    public void GetMenu(string name)
    {
        if (name == "Big Menu")
        {
            this.MacMenu.Add(BigMenu());
            this.MacMenu.Display();
        }
        else if (name == "Small Menu")
        {
            this.MacMenu.Add(SmallMenu());
            this.MacMenu.Display();
        }
        else
        {
            Console.WriteLine("Such menu does not exist. Please enter again...");
        }
    }
}