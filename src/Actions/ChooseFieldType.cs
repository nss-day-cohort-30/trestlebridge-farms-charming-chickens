using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {
    public class ChooseFieldType {
        public static void CollectInput (Farm farm, Sunflower Sunflower) {
            Console.Clear();

            Console.WriteLine ("1. Natural Field");
            Console.WriteLine ("2. Plowed Field");

            Console.WriteLine ();
            // README code
            Console.WriteLine ("Choose which type of field to plant the Sunflower seed in.");
            // Old code
            // Console.WriteLine ("What are you buying today?");

            Console.Write ("> ");
            string choice = Console.ReadLine ();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseNaturalField.CollectInput(farm, new Sunflower());
                    break;
                case 2:
                    ChoosePlowedField.CollectInput(farm, new Sunflower());
                    break;
            }}}}