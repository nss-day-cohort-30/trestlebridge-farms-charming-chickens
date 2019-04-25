using System;
using System.Collections.Generic;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Actions
{
    public class ChoosePlowedField
    {

        public static List<IPlowed> numberOfPlants = new List<IPlowed>();

        public static void CollectInput(Farm farm, IPlowed plant)
        {
            Console.Clear();

            Console.WriteLine($"How many {plant} would you like to purchase?");

            int input = Int32.Parse(Console.ReadLine());
            numberOfPlants.Clear();
            for (int i = 0; i < input; i++)
            {
                numberOfPlants.Add(plant);
            }

            for (int i = 0; i < farm.PlowedFields.Count; i++)
            {
                if (farm.PlowedFields[i].Flowers.Count < farm.PlowedFields[i].Capacity)
                {
                PlowedField specificField = farm.PlowedFields[i];
                Console.WriteLine($"{i + 1}. {specificField}");
                }

                }

            Console.WriteLine();



            // How can I output the type of plant chosen here?
            Console.WriteLine($"Grow the plant where?");

            Console.Write("> ");

            try
            {
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                farm.PlowedFields[choice].AddResources(numberOfPlants);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IPlowed>(plant, choice);

        }
    }
}