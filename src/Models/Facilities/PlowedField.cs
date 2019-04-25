using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;
using Trestlebridge.Models.HashSets;
using System.Linq;


namespace Trestlebridge.Models.Facilities
{
    public class PlowedField : IFacility<IPlowed>
    {
        private int _capacity = 2;
        private Guid _id = Guid.NewGuid();

        private List<IPlowed> _plant = new List<IPlowed>();

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public List<IPlowed> Flowers {
            get
            {
                return _plant;
            }
        }

        public void AddResource(IPlowed plant)
        {
            if (_plant.Count < _capacity)
            {
                _plant.Add(plant);
            }
            else if (_plant.Count >= _capacity)
            {
                Console.WriteLine($@"
                This Facility Is At Full Capacity.
                Press Any Key To Return To Main Menu.");
                Console.ReadLine();

            }
        }

        public void AddResources(List<IPlowed> plants)  // TODO: Take out this method for boilerplate
        {
            if (plants.Count + plants.Count <= _capacity)
            {
                _plant.AddRange(plants);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            List<TypeCounter> FlowerCount = (
                from flower in Flowers
                group flower by flower.Type into FlowerType
                select new TypeCounter
                {
                    Type = FlowerType.Key,
                    Counter = FlowerType.Count()
                }
            ).ToList();
            output.Append($"Plowed field ( ");
            foreach (TypeCounter flower in FlowerCount)
            {
                output.Append($"{flower.Counter} {flower.Type} ");
            }
            output.Append($")\n");

            return output.ToString();
        }
    }
}