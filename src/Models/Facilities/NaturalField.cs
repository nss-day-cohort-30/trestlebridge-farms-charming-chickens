using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities {
    public class NaturalField : IFacility<INatural>
    {
        private int _capacity = 10;
        private Guid _id = Guid.NewGuid();

        private List<INatural> _plant = new List<INatural>();

        public double Capacity {
            get {
                return _capacity;
            }
        }

        public void AddResource (INatural plant)
        {
            if (_plant.Count < _capacity) {
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

        public void AddResources (List<INatural> plant)  // TODO: Take out this method for boilerplate
        {
            if (_plant.Count + plant.Count <= _capacity) {
                _plant.AddRange(plant);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Natural field ({this._plant.Count} rows of plants)\n");

            return output.ToString();
        }
    }
}