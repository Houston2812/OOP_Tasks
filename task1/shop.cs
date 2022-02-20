using System;
using System.Collections.Generic;

namespace task1
{
    public class AnimalPrice
    {
        private Animal Animal;

        private double Price;

        public AnimalPrice(Animal animal, double Price)
        {
            this.Animal = animal;
            this.Price = Price;
        }

        public double GetPrice()
        {
            return this.Price;
        }

        public Animal GetAnimal()
        {
            return this.Animal;
        }

    }

    public class Shop
    {
        private List<AnimalPrice> AnimalList;

        public Shop(List<AnimalPrice> AnimalList)
        {
            this.AnimalList = AnimalList;
        }

        public void AddAnimalToList(AnimalPrice animalPrice)
        {
            this.AnimalList.Add(animalPrice);
        }

        public AnimalPrice GetAnimalPrice(int index)
        {
            return this.AnimalList[index];
        }

        public string GetDescription(int index)
        {
            return this.AnimalList[index].GetAnimal().Description;
        }

        public char[] GetTitle(int index)
        {
            return this.AnimalList[index].GetAnimal().Title;
        }

        public int size()
        {
            return this.AnimalList.Count;
        }


    }
}