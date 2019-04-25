using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using System.Linq;
using Trestlebridge.Models.HashSets;


namespace Trestlebridge.Models.Facilities
{
    public class ChickenHouse : IFacility<IResource>
    {
        private int _capacity = 15;
        private Guid _id = Guid.NewGuid();

        private List<IResource> _animals = new List<IResource>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<IResource> Chickens
        {
            get
            {
                return _animals;
            }
        }

        public void AddResource(IResource animal)
        {
            if (_animals.Count < _capacity)
            {
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

        public void AddResources(List<IResource> animals)  // TODO: Take out this method for boilerplate
        {
            if (_animals.Count + animals.Count <= _capacity)
            {
                _animals.AddRange(animals);
            }

        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";
            if (_animals.Count == 0)
            {
                output.Append($"Grazing field ({_animals.Count} animals)\n");
            }

            List<TypeCounter> AnimalCount = (
                from chicken in Chickens
                group chicken by chicken.Type into AnimalType
                select new TypeCounter
                {
                    Type = AnimalType.Key,
                    Counter = AnimalType.Count()
                }
            ).ToList();
            output.Append($"Chicken house ( ");
            foreach (TypeCounter animal in AnimalCount)
            {
                output.Append($"{animal.Counter} {animal.Type} ");
            }
            output.Append($")");

            return output.ToString();
        }


    }
}