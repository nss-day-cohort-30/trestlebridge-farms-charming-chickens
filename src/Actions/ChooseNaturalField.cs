using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseNaturalField {
        public static void CollectInput (Farm farm, INatural plant) {
            Console.Clear();

            Console.WriteLine ($"How many {plant} would you like to purchase?");
            int numberOfPlants = Int32.Parse(Console.ReadLine ());


            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Natural Field");
            }

            Console.WriteLine ();



            // How can I output the type of plant chosen here?
            Console.WriteLine ($"Grow the plant where?");

            Console.Write ("> ");
            try
                {
                    int choice = Int32.Parse(Console.ReadLine ()) - 1;
                    farm.NaturalFields[choice].AddResource(plant);
                }
            catch (ArgumentOutOfRangeException ex)
                {

                }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<INatural>(plant, choice);

        }
    }
}