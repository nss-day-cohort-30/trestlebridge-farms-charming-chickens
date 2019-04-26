using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class Processing
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");

            Console.WriteLine();

            Console.WriteLine("Choose equipment to use.");

            Console.Write("> ");
            string choice = Console.ReadLine();
            try
            {
                switch (Int32.Parse(choice))
                {
                    case 1:
                        ChooseSeedHarvester.CollectInput(farm, new SeedHarvester());
                        break;
                    // case 2:
                    //     ChooseMeatHarvester.CollectInput(farm, new MeatProcessor());
                    //     break;
                    case 3:
                        ChooseEggHarvester.CollectInput(farm, new EggHarvester());
                        break;
                    case 4:
                        ChooseComposter.CollectInput(farm, new Composter());
                        break;
                    case 5:
                        ChooseFeatherHarvester.CollectInput(farm, new FeatherHarvester());
                        break;
                    default:
                        break;
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}