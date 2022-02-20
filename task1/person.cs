using System;
using System.Collections.Generic;

namespace task1
{
    public class Person
    {
        private string PhoneNumber;
        private string Email;
        private List<Animal> Pets = new List<Animal>();

        public Person(string PhoneNumber, string Email, List<Animal> Pets)
        {
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
            this.Pets = Pets;
        }

        public List<Animal> GetAnimals()
        {
            return this.Pets;
        }

        public void AddAnimal(Animal Pet)
        {
            this.Pets.Add(Pet);
        }

        public bool RemoveAnimal(Animal Pet)
        {
            this.Pets.Remove(Pet);
            foreach (Animal Pet_I in this.Pets)
            {
                Console.Write(Pet_I.ToString() + " ");
            }
            Console.WriteLine();
            return true;
        }

        public string GetEmail()
        {
            return this.Email;
        }

    }   
}