using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.HashSets;
using Trestlebridge.Actions;
using System.Linq;


namespace Trestlebridge.Models.Facilities {
    public class GrazingField : IFacility<IGrazing>
    {
        private int _capacity = 20;
        private Guid _id = Guid.NewGuid();

        private List<IGrazing> _animals = new List<IGrazing>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public List<IGrazing> Animals
        {
            get
            {
                return _animals;
            }
        }

        public void AddResource (IGrazing animal)
        {
            if (_animals.Count < _capacity) {
                _animals.Add(animal);
            }
             else if (_animals.Count >= _capacity)
            {
                Console.WriteLine($@"
                This Facility Is At Full Capacity.
                Press Any Key To Return To Main Menu.");
                Console.ReadLine();

            }
        }

        public void AddResources (List<IGrazing> animals)  // TODO: Take out this method for boilerplate
        {
            if (_animals.Count + animals.Count <= _capacity) {
                _animals.AddRange(animals);
            }
        }


        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            List<TypeCounter> AnimalCount = (
                from animal in Animals
                group animal by animal.Type into AnimalType
                select new TypeCounter {
                    Type = AnimalType.Key,
                    Counter = AnimalType.Count()
                }
            ).ToList();

            foreach(TypeCounter animal in AnimalCount)
            {
                output.Append($"Grazing field ({animal.Counter} {animal.Type})\n");
            }


            return output.ToString();
        }
    }
}

            // List<MoneyinBank> whereTheRich = (
            //     from customer in millionaires
            //     group customer by customer.Bank into BankGroup
            //     select new MoneyinBank {
            //         Name = BankGroup.Key,
            //         Count = BankGroup.Count()
            //     }
            // ).ToList();
            // foreach (MoneyinBank entry in whereTheRich) {
            //     Console.WriteLine($"{entry.Name}: {entry.Count}");