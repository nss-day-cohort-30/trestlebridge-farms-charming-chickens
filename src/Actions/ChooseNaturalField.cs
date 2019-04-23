using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions {
    public class ChooseNaturalField {
        public static List<INatural> numberOfPlants = new List<INatural>();
        public static void CollectInput (Farm farm, INatural plant) {
            Console.Clear();


        Console.WriteLine ($"How many {plant}s would you like to purchase?");

            int input = Int32.Parse(Console.ReadLine ());
            for ( int i = 0; i < input; i++ )
            {
                numberOfPlants.Add(plant);
            }


            for (int i = 0; i < farm.NaturalFields.Count; i++)
            {
                Console.WriteLine ($"{i + 1}. Natural Field");
            }

            Console.WriteLine ();



            // How can I output the type of plant chosen here?
            Console.WriteLine ($"Where would you like to plant the {plant}s?");

            Console.Write ("> ");
            try
                {
                    int choice = Int32.Parse(Console.ReadLine ()) - 1;
                    farm.NaturalFields[choice].AddResources(numberOfPlants);
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