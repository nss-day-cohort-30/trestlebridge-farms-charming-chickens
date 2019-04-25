using System;
using System.Collections.Generic;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Animals {
    public class Goat : IGrazing, ICompost {

        private Guid _id = Guid.NewGuid();

        private string _shortId {
            get {
                return this._id.ToString().Substring(this._id.ToString().Length - 6);
            }
        }

        private double _compostProduced = 7.5;

        public double Compost () {
            return _compostProduced;
        }
        public double GrassPerDay { get; set; } = 5.4;
        public string Type { get; } = "Goat";

        // Methods
        public void Graze () {
            Console.WriteLine($"Cow {this._shortId} just ate {this.GrassPerDay}kg of grass");
        }

        public override string ToString () {
            return $"Goat {this._shortId}. I'm a goat!";
        }
    }
}