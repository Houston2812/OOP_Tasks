using System;
using System.Collections.Generic;

namespace task1
{
    public class Contract
    {
        private Animal Animal;
        private Person Person;
        private double Price;
        private DateTime Date;

        public Contract(Animal Animal, Person Person, double Price, DateTime Date)
        {
            this.Animal = Animal;
            this.Person = Person;
            this.Price = Price;
            this.Date = Date;
        }
        
        public override string ToString()
        {
            return "\tAnimal name: " + new string(this.Animal.Title) + "\n\tPerson: " + this.Person.GetEmail() + "\n\tPrice: " + this.Price + "\n\tDate: " + this.Date + "\n";
        }
    }

    public class ContractRepository
    {
        private List<Contract> Contracts;

        public ContractRepository(List<Contract> Contracts)
        {
            this.Contracts = Contracts;
        }
        
        public void AddContract(Contract contract)
        {
            this.Contracts.Add(contract);
        }

        public Contract GetContract(int index)
        {
            return this.Contracts[index];
        }

        public int size()
        {   
            return this.Contracts.Count;
        }
    }
}