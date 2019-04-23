using System;
using Trestlebridge.Interfaces;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IResource, ICompost, ISeedProducing, IPlowed, INatural
    {
        private int _seedsProduced = 650;
        private double _compostProduced = 30.3;

        public string Type { get; } = "Sunflower";

        public double Harvest () {
            return _seedsProduced;

        }
        public double Poop () {
            return _compostProduced;

        }

        public override string ToString () {
            return $"Sunflowers (not Post Malone)";
        }
    }
}