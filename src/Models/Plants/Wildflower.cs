using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IResource, ICompost, INatural
    {
        private double _compostProduced = 30.3;
        public string Type { get; } = "Sesame";

        public double Poop () {
            return _compostProduced;
        }

        public override string ToString () {
            return $"Wildflowers are really pretty and stuff.";
        }
    }
}