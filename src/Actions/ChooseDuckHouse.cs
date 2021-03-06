using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions
{
    public class ChooseDuckHouse
    {
        public static void CollectInput(Farm farm, IResource animal)
        {
            Console.Clear();

            for (int i = 0; i < farm.DuckHouses.Count; i++)
            {
                if (farm.DuckHouses[i].Ducks.Count < farm.DuckHouses[i].Capacity)
                {
                    DuckHouse specificHouse = farm.DuckHouses[i];
                    Console.WriteLine($"{i + 1}. {specificHouse}");
                }
            }

            Console.WriteLine();

            // How can I output the type of animal chosen here?
            Console.WriteLine($"Place the animal where?");

            Console.Write("> ");
            try
            {
                int choice = Int32.Parse(Console.ReadLine()) - 1;
                farm.DuckHouses[choice].AddResource(animal);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }


            /*
                Couldn't get this to work. Can you?
                Stretch goal. Only if the app is fully functional.
             */
            // farm.PurchaseResource<IGrazing>(animal, choice);

        }
    }
}