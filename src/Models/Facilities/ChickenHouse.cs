using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


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

        public void AddResource(IResource animal)
        {
            if (_animals.Count < _capacity)
            {
                _animals.Add(animal);
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

            output.Append($"Chicken house ({this._animals.Count} animals)\n");

            return output.ToString();
        }
    }
}