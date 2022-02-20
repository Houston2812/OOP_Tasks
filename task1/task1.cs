using System;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractRepository contractRepository = new ContractRepository(new List<Contract> ());

            List <Animal> HuseynPets = new List <Animal>(); 
            Person Huseyn = new Person("+994111111111", "huseyn@gmail.com" , HuseynPets);
           
            Cat cat = new Cat("Little".ToCharArray(), "This is my little Little", Huseyn);
            Dog dog = new Dog("Biggie".ToCharArray(), "This is my big Biggie", Huseyn);

            Huseyn.AddAnimal(cat);
            Huseyn.AddAnimal(dog);

            HuseynPets = Huseyn.GetAnimals();
            
            Console.WriteLine("\nPets\n");
            foreach (Animal PetI in HuseynPets)
            {
                Console.WriteLine(PetI.ToString());
            }

            Shop AnimalShop = new Shop(new List<AnimalPrice> ());

            AnimalShop.AddAnimalToList(new AnimalPrice(cat, 50));
            AnimalShop.AddAnimalToList(new AnimalPrice(dog, 100));

            int ShopSize = AnimalShop.size();

            Console.WriteLine("\nShop\n");
            for (int i = 0; i < ShopSize; i++)
            {   
                Console.WriteLine("Index: " + i);
                Console.WriteLine("\tTitle: " + new string(AnimalShop.GetTitle(i)) + "\n\tDescription: " + AnimalShop.GetDescription(i)); 
            }

            Contract CatContract = new Contract(cat, Huseyn, AnimalShop.GetAnimalPrice(0).GetPrice(), DateTime.Now);
            Contract DogContract = new Contract(dog, Huseyn, AnimalShop.GetAnimalPrice(1).GetPrice(), DateTime.Now);

            contractRepository.AddContract(CatContract);
            contractRepository.AddContract(DogContract);

            Console.WriteLine("\nContracts: ");

            for (int i = 0; i < contractRepository.size(); i++)
            {   
                Console.WriteLine("Index: "  + i);
                Console.WriteLine(contractRepository.GetContract(i).ToString());
            }

        }
    }
}
