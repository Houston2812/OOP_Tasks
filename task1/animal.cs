using System;

namespace task1
{
    public abstract class Animal
    {
        public char[] Title { get; set; }
        //  = new char[32];
        public string Description { get; set; }

        public Person Owner { get; set; }

        public abstract string Sound();

        public override string ToString()
        {
            return "Animal is: " + new string(this.Title) + " and owner email is : " + this.Owner.GetEmail();
        }
    }

    public class Dog: Animal
    {
        public Dog(char[] Title, string Description, Person Owner)
        {
            this.Title = Title;
            this.Description = Description;
            this.Owner = Owner;
        }

        public override string Sound()
        {
            return "Haw-Haw";
        }
       
    }

    public class Cat: Animal
    {
        public Cat(char[] Title, string Description, Person Owner)
        {
            this.Title = Title;
            this.Description = Description;
            this.Owner = Owner;
        }

        public override string Sound()
        {
            return "Meow-Meow";
        }
    }
}