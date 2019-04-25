using System;
using System.Linq;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;

namespace Trestlebridge.Actions {
    public class ChooseChickenHouse {
        public static void CollectInput (Farm farm, IResource animal) {
            Console.Clear();

            for (int i = 0; i < farm.ChickenHouses.Count; i++)
            {
                if (farm.ChickenHouses[i].Chickens.Count < farm.ChickenHouses[i].Capacity)
                {
                    ChickenHouse specificHouse = farm.ChickenHouses[i];
                    Console.WriteLine ($"{i + 1}. {specificHouse}");
                }
            }

            Console.WriteLine ();

            // How can I output the type of animal chosen here?
            Console.WriteLine ($"Place the animal where?");

            Console.Write ("> ");

            try
                {
                    int choice = Int32.Parse(Console.ReadLine ()) -1;
                    farm.ChickenHouses[choice].AddResource(animal);
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