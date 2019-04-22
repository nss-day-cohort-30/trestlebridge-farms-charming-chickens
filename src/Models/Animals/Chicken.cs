using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Chicken : IResource, IMeatProducing {

        private Guid _id = Guid.NewGuid();

        // the meat produced for chickens is a little confusing so i am going to come back
        // to this later  -- sam
        private double _meatProduced = 18.25;

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        // public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Chicken";

        // Methods
        // public void Graze () {
        //     Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        // }

        public double Butcher () {
            return _meatProduced;
        }

        public override string ToString () {
            return $"Chicken {this._shortId}. Baawk!";
        }
    }
}